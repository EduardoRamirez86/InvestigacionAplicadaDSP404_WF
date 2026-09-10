using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvestigaciónAplicadaDSP404_WF.Interfaces;
using InvestigaciónAplicadaDSP404_WF.Models;
using InvestigaciónAplicadaDSP404_WF.Persistence;
using InvestigaciónAplicadaDSP404_WF.Services;

namespace InvestigaciónAplicadaDSP404_WF
{
    public partial class Form1 : Form
    {
        private readonly IWeatherApiService _weatherApiService;
        private readonly IFavoriteRepository _favoriteRepository;

        // Estado de la consulta activa en pantalla
        private GeoLocation _currentLocation;
        private WeatherCurrentData _currentWeather;
        private bool _isPopulatingCombo = false;

        public Form1(IWeatherApiService weatherApiService = null, IFavoriteRepository favoriteRepository = null)
        {
            InitializeComponent();

            _weatherApiService = weatherApiService ?? new WeatherApiService();
            _favoriteRepository = favoriteRepository ?? new FavoriteFileRepository();

            ConfigureEventHandlers();
        }

        private void ConfigureEventHandlers()
        {
            this.Load += Form1_Load;
            btnConsultar.Click += btnConsultar_Click;
            txtCiudad.KeyDown += txtCiudad_KeyDown;
            cboOpcionesCiudad.SelectedIndexChanged += cboOpcionesCiudad_SelectedIndexChanged;
            btnGuardarFavorito.Click += btnGuardarFavorito_Click;
            btnRecargar.Click += btnRecargar_Click;
            btnAbrirCsv.Click += btnAbrirCsv_Click;
            btnEliminar.Click += btnEliminar_Click;
            dgvFavoritos.CellDoubleClick += dgvFavoritos_CellDoubleClick;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarFavoritosAsync();
            txtCiudad.Focus();
        }

        private void txtCiudad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnConsultar.PerformClick();
            }
        }

        /// <summary>
        /// Busca las opciones de ciudades que coinciden con el texto ingresado
        /// y puebla el desplegable de opciones con sus respectivas coordenadas (Lat/Lon).
        /// </summary>
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string query = txtCiudad.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                SetStatus("Ingresa el nombre de una ciudad o región para buscar.", Color.FromArgb(245, 180, 50));
                txtCiudad.Focus();
                return;
            }

            SetLoadingState(true);
            SetStatus($"Buscando coincidencias para '{query}' en Open-Meteo Geocoding...", Color.FromArgb(56, 189, 248));

            try
            {
                var locations = await _weatherApiService.SearchCitiesAsync(query);

                if (locations == null || locations.Count == 0)
                {
                    cboOpcionesCiudad.Items.Clear();
                    SetStatus($"No se encontraron resultados para '{query}'. Intenta con otro término.", Color.FromArgb(245, 100, 100));
                    return;
                }

                _isPopulatingCombo = true;
                cboOpcionesCiudad.Items.Clear();

                foreach (var loc in locations)
                {
                    cboOpcionesCiudad.Items.Add(loc);
                }

                _isPopulatingCombo = false;

                // Seleccionar automáticamente la primera opción y consultar su clima
                cboOpcionesCiudad.SelectedIndex = 0;
                await CargarClimaDeUbicacionAsync((GeoLocation)cboOpcionesCiudad.SelectedItem);
            }
            catch (TimeoutException tex)
            {
                SetStatus($"Tiempo de espera agotado: {tex.Message}", Color.FromArgb(245, 100, 100));
                MessageBox.Show(tex.Message, "Tiempo de Espera Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException hrex)
            {
                SetStatus($"Error de conexión a internet: {hrex.Message}", Color.FromArgb(245, 100, 100));
                MessageBox.Show($"No se pudo conectar con el servicio web de Open-Meteo:\n\n{hrex.Message}\n\nPuedes consultar tus registros guardados localmente.", "Aviso de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetStatus($"Error inesperado: {ex.Message}", Color.FromArgb(245, 100, 100));
            }
            finally
            {
                SetLoadingState(false);
            }
        }

        /// <summary>
        /// Cuando el usuario cambia la ciudad seleccionada en el desplegable de sugerencias,
        /// se actualizan de inmediato las coordenadas y la telemetría climática.
        /// </summary>
        private async void cboOpcionesCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isPopulatingCombo || cboOpcionesCiudad.SelectedItem == null)
            {
                return;
            }

            if (cboOpcionesCiudad.SelectedItem is GeoLocation selectedLocation)
            {
                SetLoadingState(true);
                try
                {
                    await CargarClimaDeUbicacionAsync(selectedLocation);
                }
                finally
                {
                    SetLoadingState(false);
                }
            }
        }

        /// <summary>
        /// Consulta el clima para una ubicación geográfica específica y actualiza los controles.
        /// </summary>
        private async Task CargarClimaDeUbicacionAsync(GeoLocation location)
        {
            SetStatus($"Obteniendo telemetría climática para {location.Name} (Lat: {location.Latitude:F4}, Lon: {location.Longitude:F4})...", Color.FromArgb(56, 189, 248));

            var weather = await _weatherApiService.GetCurrentWeatherAsync(location.Latitude, location.Longitude);

            _currentLocation = location;
            _currentWeather = weather;

            // Actualizar datos de ubicación y coordenadas
            lblCityName.Text = location.Name;
            string regionPart = !string.IsNullOrWhiteSpace(location.Admin1) ? $"{location.Admin1}, " : "";
            lblCountryName.Text = $"{regionPart}{location.Country} ({location.CountryCode})";
            
            // Latitud y Longitud visibles
            lblCoordLatitud.Text = $"Latitud: {location.Latitude:F4}°";
            lblCoordLongitud.Text = $"Longitud: {location.Longitude:F4}°";

            // Actualizar telemetría de clima
            lblTemperature.Text = $"{weather.Temperature:F1} °C";
            lblCondition.Text = weather.ConditionDescription;
            lblHumedadVal.Text = $"Humedad: {weather.RelativeHumidity} %";
            lblVientoVal.Text = $"Viento: {weather.WindSpeed:F1} km/h";
            lblMedicionHora.Text = $"Última medición: {weather.Timestamp:yyyy-MM-dd HH:mm:ss} (Hora local)";

            btnGuardarFavorito.Enabled = true;
            SetStatus($"Clima actualizado exitosamente para {location.Name} (HTTP 200 OK)", Color.FromArgb(46, 190, 130));
        }

        private async void btnGuardarFavorito_Click(object sender, EventArgs e)
        {
            if (_currentLocation == null || _currentWeather == null)
            {
                SetStatus("Primero realiza una búsqueda para poder guardar la consulta.", Color.FromArgb(245, 180, 50));
                return;
            }

            try
            {
                btnGuardarFavorito.Enabled = false;
                SetStatus($"Guardando '{_currentLocation.Name}' en archivo local CSV...", Color.FromArgb(56, 189, 248));

                var record = new FavoriteWeatherRecord(
                    _currentLocation.Name,
                    _currentLocation.Country,
                    _currentLocation.Latitude,
                    _currentLocation.Longitude,
                    _currentWeather.Temperature,
                    _currentWeather.RelativeHumidity,
                    _currentWeather.WindSpeed,
                    _currentWeather.ConditionDescription,
                    DateTime.Now
                );

                await _favoriteRepository.SaveAsync(record);
                await CargarFavoritosAsync();

                SetStatus($"'{record.City}' se guardó correctamente en tus favoritos locales.", Color.FromArgb(46, 190, 130));
            }
            catch (Exception ex)
            {
                SetStatus($"Error al guardar: {ex.Message}", Color.FromArgb(245, 100, 100));
            }
            finally
            {
                btnGuardarFavorito.Enabled = true;
            }
        }

        private async void btnRecargar_Click(object sender, EventArgs e)
        {
            await CargarFavoritosAsync();
            SetStatus("Lista de favoritos recargada desde el archivo CSV.", Color.FromArgb(46, 190, 130));
        }

        private void btnAbrirCsv_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(_favoriteRepository.FilePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(_favoriteRepository.FilePath) { UseShellExecute = true });
                    SetStatus($"Abriendo archivo CSV: {_favoriteRepository.FilePath}", Color.FromArgb(46, 190, 130));
                }
                else
                {
                    MessageBox.Show($"El archivo CSV aún no existe en disco:\n{_favoriteRepository.FilePath}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el archivo CSV:\n\n{ex.Message}", "Error al Abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFavoritos.SelectedRows.Count == 0)
            {
                SetStatus("Selecciona una fila de la tabla para eliminar.", Color.FromArgb(245, 180, 50));
                return;
            }

            var selectedRow = dgvFavoritos.SelectedRows[0];
            string cityName = selectedRow.Cells["colCiudad"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(cityName))
            {
                return;
            }

            var dialogResult = MessageBox.Show(
                $"¿Deseas eliminar '{cityName}' de las consultas guardadas?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    bool deleted = await _favoriteRepository.DeleteAsync(cityName);
                    if (deleted)
                    {
                        await CargarFavoritosAsync();
                        SetStatus($"'{cityName}' fue eliminado del archivo CSV.", Color.FromArgb(245, 100, 100));
                    }
                }
                catch (Exception ex)
                {
                    SetStatus($"Error al eliminar: {ex.Message}", Color.FromArgb(245, 100, 100));
                }
            }
        }

        /// <summary>
        /// Permite inspeccionar un favorito guardado al hacer doble clic en el DataGridView (Modo Offline).
        /// </summary>
        private void dgvFavoritos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvFavoritos.Rows.Count)
            {
                return;
            }

            var row = dgvFavoritos.Rows[e.RowIndex];
            string ciudad = row.Cells["colCiudad"].Value?.ToString() ?? string.Empty;
            string pais = row.Cells["colPais"].Value?.ToString() ?? string.Empty;
            string lat = row.Cells["colLatitud"].Value?.ToString() ?? "--";
            string lon = row.Cells["colLongitud"].Value?.ToString() ?? "--";
            string temp = row.Cells["colTemp"].Value?.ToString() ?? "--";
            string hum = row.Cells["colHumedad"].Value?.ToString() ?? "--";
            string viento = row.Cells["colViento"].Value?.ToString() ?? "--";
            string condicion = row.Cells["colCondicion"].Value?.ToString() ?? "Variable";
            string fecha = row.Cells["colFecha"].Value?.ToString() ?? "--";

            lblCityName.Text = ciudad;
            lblCountryName.Text = $"{pais} • [Registro guardado localmente]";
            lblCoordLatitud.Text = $"Latitud: {lat}°";
            lblCoordLongitud.Text = $"Longitud: {lon}°";
            lblTemperature.Text = $"{temp} °C";
            lblCondition.Text = condicion;
            lblHumedadVal.Text = $"Humedad: {hum} %";
            lblVientoVal.Text = $"Viento: {viento} km/h";
            lblMedicionHora.Text = $"Guardado el: {fecha}";

            btnGuardarFavorito.Enabled = false;
            SetStatus($"Visualizando '{ciudad}' desde persistencia local (Modo Offline).", Color.FromArgb(125, 200, 245));
        }

        private async Task CargarFavoritosAsync()
        {
            try
            {
                List<FavoriteWeatherRecord> records = await _favoriteRepository.GetAllAsync();

                dgvFavoritos.Rows.Clear();
                foreach (var r in records)
                {
                    dgvFavoritos.Rows.Add(
                        r.City,
                        r.Country,
                        r.Latitude.ToString("F4", CultureInfo.InvariantCulture),
                        r.Longitude.ToString("F4", CultureInfo.InvariantCulture),
                        r.Temperature.ToString("F1", CultureInfo.InvariantCulture),
                        r.Humidity,
                        r.WindSpeed.ToString("F1", CultureInfo.InvariantCulture),
                        r.Condition,
                        r.SavedAt.ToString("yyyy-MM-dd HH:mm")
                    );
                }

                tsLblRecordsCount.Text = $"Favoritos locales: {records.Count}";
            }
            catch (Exception ex)
            {
                SetStatus($"No se pudieron cargar los favoritos locales: {ex.Message}", Color.FromArgb(245, 100, 100));
            }
        }

        private void SetLoadingState(bool isLoading)
        {
            pbLoading.Visible = isLoading;
            btnConsultar.Enabled = !isLoading;
            txtCiudad.Enabled = !isLoading;
            cboOpcionesCiudad.Enabled = !isLoading;
        }

        private void SetStatus(string message, Color textColor)
        {
            lblStatusMessage.Text = message;
            lblStatusMessage.ForeColor = textColor;
        }
    }
}
