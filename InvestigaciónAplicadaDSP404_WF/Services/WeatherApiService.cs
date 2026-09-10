using System;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using InvestigaciónAplicadaDSP404_WF.Interfaces;
using InvestigaciónAplicadaDSP404_WF.Models;
using InvestigaciónAplicadaDSP404_WF.Models.Dtos;

namespace InvestigaciónAplicadaDSP404_WF.Services
{
    /// <summary>
    /// Servicio de infraestructura que consume la API REST pública de Open-Meteo
    /// de manera asíncrona mediante una instancia reutilizable de HttpClient.
    /// </summary>
    public class WeatherApiService : IWeatherApiService
    {
        // Instancia estática singleton de HttpClient para evitar agotamiento de sockets (socket exhaustion)
        // según las mejores prácticas documentadas en la Investigación Aplicada 2.
        private static readonly HttpClient HttpClientInstance;

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        static WeatherApiService()
        {
            HttpClientInstance = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(12)
            };
            HttpClientInstance.DefaultRequestHeaders.UserAgent.ParseAdd("WeatherDesk-UDB/1.0 (DSP404; C# WinForms)");
        }

        private readonly HttpClient _httpClient;

        public WeatherApiService(HttpClient httpClient = null)
        {
            // Permite inyección de HttpClient para pruebas unitarias con mocks si es requerido
            _httpClient = httpClient ?? HttpClientInstance;
        }

        /// <inheritdoc />
        public async Task<System.Collections.Generic.List<GeoLocation>> SearchCitiesAsync(string cityName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                throw new ArgumentException("El nombre de la ciudad a consultar no puede estar vacío.", nameof(cityName));
            }

            string sanitizedCity = Uri.EscapeDataString(cityName.Trim());
            string url = $"https://geocoding-api.open-meteo.com/v1/search?name={sanitizedCity}&count=8&language=es&format=json";

            try
            {
                using (var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException($"Error de servidor en Open-Meteo Geocoding (Código HTTP {(int)response.StatusCode}: {response.ReasonPhrase}).");
                    }

                    using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        var geocodingData = await JsonSerializer.DeserializeAsync<GeocodingApiResponse>(stream, JsonOptions, cancellationToken).ConfigureAwait(false);

                        var list = new System.Collections.Generic.List<GeoLocation>();
                        if (geocodingData?.Results != null)
                        {
                            foreach (var item in geocodingData.Results)
                            {
                                list.Add(new GeoLocation(item.Name, item.Country, item.CountryCode, item.Latitude, item.Longitude, item.Admin1));
                            }
                        }

                        return list;
                    }
                }
            }
            catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                throw new TimeoutException("La solicitud a Open-Meteo Geocoding excedió el tiempo máximo de espera (timeout de 12s). Verifica tu conexión a internet.");
            }
        }

        /// <inheritdoc />
        public async Task<GeoLocation> SearchCityAsync(string cityName, CancellationToken cancellationToken = default)
        {
            var results = await SearchCitiesAsync(cityName, cancellationToken).ConfigureAwait(false);
            return results.Count > 0 ? results[0] : null;
        }

        /// <inheritdoc />
        public async Task<WeatherCurrentData> GetCurrentWeatherAsync(double latitude, double longitude, CancellationToken cancellationToken = default)
        {
            string latStr = latitude.ToString("F4", CultureInfo.InvariantCulture);
            string lonStr = longitude.ToString("F4", CultureInfo.InvariantCulture);
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={latStr}&longitude={lonStr}&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m";

            try
            {
                using (var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException($"Error de servidor en Open-Meteo Forecast (Código HTTP {(int)response.StatusCode}: {response.ReasonPhrase}).");
                    }

                    using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        var forecastData = await JsonSerializer.DeserializeAsync<WeatherForecastApiResponse>(stream, JsonOptions, cancellationToken).ConfigureAwait(false);

                        if (forecastData?.Current == null)
                        {
                            throw new InvalidOperationException("La respuesta recibida de Open-Meteo no contiene mediciones meteorológicas actuales.");
                        }

                        var current = forecastData.Current;
                        DateTime timestamp;
                        if (!DateTime.TryParse(current.Time, CultureInfo.InvariantCulture, DateTimeStyles.None, out timestamp))
                        {
                            timestamp = DateTime.Now;
                        }

                        return new WeatherCurrentData(
                            current.Temperature2m,
                            current.RelativeHumidity2m,
                            current.WindSpeed10m,
                            current.WeatherCode,
                            timestamp
                        );
                    }
                }
            }
            catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                throw new TimeoutException("La solicitud al servicio meteorológico excedió el tiempo de espera. Por favor, verifica tu conexión a internet.");
            }
        }
    }
}
