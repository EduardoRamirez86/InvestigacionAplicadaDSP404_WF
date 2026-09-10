using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InvestigaciónAplicadaDSP404_WF.Interfaces;
using InvestigaciónAplicadaDSP404_WF.Models;

namespace InvestigaciónAplicadaDSP404_WF.Persistence
{
    /// <summary>
    /// Repositorio para la persistencia local de consultas meteorológicas en un archivo CSV,
    /// manipulando colecciones genéricas List&lt;FavoriteWeatherRecord&gt; de manera asíncrona y segura.
    /// </summary>
    public class FavoriteFileRepository : IFavoriteRepository
    {
        private const string CsvHeader = "Ciudad,Pais,Latitud,Longitud,Temperatura,Humedad,Viento,Condicion,FechaGuardado";
        private readonly string _filePath;
        private readonly SemaphoreSlim _fileLock = new SemaphoreSlim(1, 1);

        public FavoriteFileRepository(string customFilePath = null)
        {
            if (string.IsNullOrWhiteSpace(customFilePath))
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                if (string.IsNullOrWhiteSpace(baseDir) || baseDir.IndexOf("System32", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    baseDir = Path.GetDirectoryName(typeof(FavoriteFileRepository).Assembly.Location) ?? AppDomain.CurrentDomain.BaseDirectory;
                }

                string dataFolder = Path.Combine(baseDir, "Data");
                
                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }

                _filePath = Path.Combine(dataFolder, "favoritos_clima.csv");
            }
            else
            {
                _filePath = customFilePath;
            }

            EnsureFileInitialized();
        }

        public string FilePath => _filePath;

        /// <summary>
        /// Inicializa el archivo CSV con cabecera y datos de semilla si no existe (Regla 13: Data Seeding).
        /// </summary>
        private void EnsureFileInitialized()
        {
            if (!File.Exists(_filePath))
            {
                var seedData = new List<FavoriteWeatherRecord>
                {
                    new FavoriteWeatherRecord("San Salvador", "El Salvador", 13.6894, -89.1872, 27.5, 65, 14.0, "Parcialmente nublado", DateTime.Now.AddHours(-2)),
                    new FavoriteWeatherRecord("Madrid", "España", 40.4168, -3.7038, 19.2, 48, 11.2, "Cielo despejado", DateTime.Now.AddHours(-5)),
                    new FavoriteWeatherRecord("Ciudad de México", "México", 19.4326, -99.1332, 22.0, 55, 12.5, "Mayormente despejado", DateTime.Now.AddDays(-1))
                };

                using (var writer = new StreamWriter(_filePath, false, Encoding.UTF8))
                {
                    writer.WriteLine(CsvHeader);
                    foreach (var record in seedData)
                    {
                        writer.WriteLine(record.ToCsvLine());
                    }
                }
            }
        }

        /// <inheritdoc />
        public async Task<List<FavoriteWeatherRecord>> GetAllAsync()
        {
            await _fileLock.WaitAsync().ConfigureAwait(false);
            try
            {
                var records = new List<FavoriteWeatherRecord>();

                if (!File.Exists(_filePath))
                {
                    return records;
                }

                using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string line;
                    bool isFirstLine = true;

                    while ((line = await reader.ReadLineAsync().ConfigureAwait(false)) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        // Saltar encabezado
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            if (line.StartsWith("Ciudad", StringComparison.OrdinalIgnoreCase))
                            {
                                continue;
                            }
                        }

                        var record = FavoriteWeatherRecord.FromCsvLine(line);
                        if (record != null)
                        {
                            records.Add(record);
                        }
                    }
                }

                return records;
            }
            finally
            {
                _fileLock.Release();
            }
        }

        /// <inheritdoc />
        public async Task SaveAsync(FavoriteWeatherRecord record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record), "El registro de clima favorito no puede ser nulo.");
            }

            var currentList = await GetAllAsync().ConfigureAwait(false);

            // Evitar duplicados por nombre de ciudad actualizando el existente o agregando uno nuevo
            int existingIndex = currentList.FindIndex(r => r.City.Equals(record.City, StringComparison.OrdinalIgnoreCase));
            if (existingIndex >= 0)
            {
                currentList[existingIndex] = record;
            }
            else
            {
                currentList.Insert(0, record);
            }

            await SaveAllAsync(currentList).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task SaveAllAsync(List<FavoriteWeatherRecord> records)
        {
            if (records == null)
            {
                throw new ArgumentNullException(nameof(records), "La lista de registros no puede ser nula.");
            }

            await _fileLock.WaitAsync().ConfigureAwait(false);
            try
            {
                using (var stream = new FileStream(_filePath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    await writer.WriteLineAsync(CsvHeader).ConfigureAwait(false);
                    foreach (var item in records)
                    {
                        await writer.WriteLineAsync(item.ToCsvLine()).ConfigureAwait(false);
                    }
                }
            }
            finally
            {
                _fileLock.Release();
            }
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAsync(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                return false;
            }

            var currentList = await GetAllAsync().ConfigureAwait(false);
            int removedCount = currentList.RemoveAll(r => r.City.Equals(cityName.Trim(), StringComparison.OrdinalIgnoreCase));

            if (removedCount > 0)
            {
                await SaveAllAsync(currentList).ConfigureAwait(false);
                return true;
            }

            return false;
        }
    }
}
