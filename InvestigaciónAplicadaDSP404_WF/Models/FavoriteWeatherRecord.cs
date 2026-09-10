using System;
using System.Globalization;

namespace InvestigaciónAplicadaDSP404_WF.Models
{
    /// <summary>
    /// Entidad que representa un registro de consulta favorita guardado localmente en archivo (CSV).
    /// </summary>
    public class FavoriteWeatherRecord
    {
        public string City { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string Condition { get; set; }
        public DateTime SavedAt { get; set; }

        public FavoriteWeatherRecord()
        {
            City = string.Empty;
            Country = string.Empty;
            Condition = string.Empty;
            SavedAt = DateTime.Now;
        }

        public FavoriteWeatherRecord(string city, string country, double latitude, double longitude, 
            double temperature, int humidity, double windSpeed, string condition, DateTime savedAt)
        {
            City = city ?? throw new ArgumentNullException(nameof(city));
            Country = country ?? string.Empty;
            Latitude = latitude;
            Longitude = longitude;
            Temperature = temperature;
            Humidity = humidity;
            WindSpeed = windSpeed;
            Condition = condition ?? string.Empty;
            SavedAt = savedAt;
        }

        /// <summary>
        /// Serializa el registro a una línea de formato CSV delimitado por comas.
        /// </summary>
        public string ToCsvLine()
        {
            // Escapar comas envolviendo en comillas si es necesario
            string cleanCity = City.Replace("\"", "\"\"");
            string cleanCountry = Country.Replace("\"", "\"\"");
            string cleanCondition = Condition.Replace("\"", "\"\"");

            return string.Format(CultureInfo.InvariantCulture,
                "\"{0}\",\"{1}\",{2:F4},{3:F4},{4:F1},{5},{6:F1},\"{7}\",\"{8:yyyy-MM-dd HH:mm:ss}\"",
                cleanCity, cleanCountry, Latitude, Longitude, Temperature, Humidity, WindSpeed, cleanCondition, SavedAt);
        }

        /// <summary>
        /// Parsea una línea de texto CSV a un objeto FavoriteWeatherRecord.
        /// </summary>
        public static FavoriteWeatherRecord FromCsvLine(string csvLine)
        {
            if (string.IsNullOrWhiteSpace(csvLine))
            {
                return null;
            }

            // Parser simple compatible con campos delimitados
            string[] parts = csvLine.Split(',');
            if (parts.Length < 9)
            {
                return null;
            }

            try
            {
                string city = parts[0].Trim('"', ' ');
                string country = parts[1].Trim('"', ' ');
                double lat = double.Parse(parts[2].Trim('"', ' '), CultureInfo.InvariantCulture);
                double lon = double.Parse(parts[3].Trim('"', ' '), CultureInfo.InvariantCulture);
                double temp = double.Parse(parts[4].Trim('"', ' '), CultureInfo.InvariantCulture);
                int hum = int.Parse(parts[5].Trim('"', ' '), CultureInfo.InvariantCulture);
                double wind = double.Parse(parts[6].Trim('"', ' '), CultureInfo.InvariantCulture);
                string condition = parts[7].Trim('"', ' ');
                DateTime savedAt = DateTime.ParseExact(parts[8].Trim('"', ' '), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                return new FavoriteWeatherRecord(city, country, lat, lon, temp, hum, wind, condition, savedAt);
            }
            catch
            {
                return null;
            }
        }
    }
}
