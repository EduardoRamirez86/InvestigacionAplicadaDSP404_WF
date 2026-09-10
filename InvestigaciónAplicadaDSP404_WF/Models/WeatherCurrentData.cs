using System;

namespace InvestigaciónAplicadaDSP404_WF.Models
{
    /// <summary>
    /// Entidad de dominio que representa las condiciones climáticas actuales.
    /// </summary>
    public class WeatherCurrentData
    {
        public double Temperature { get; set; }
        public int RelativeHumidity { get; set; }
        public double WindSpeed { get; set; }
        public int WeatherCode { get; set; }
        public DateTime Timestamp { get; set; }

        public string ConditionDescription => WeatherConditionHelper.GetDescription(WeatherCode);

        public WeatherCurrentData()
        {
            Timestamp = DateTime.Now;
        }

        public WeatherCurrentData(double temperature, int relativeHumidity, double windSpeed, int weatherCode, DateTime timestamp)
        {
            Temperature = temperature;
            RelativeHumidity = relativeHumidity;
            WindSpeed = windSpeed;
            WeatherCode = weatherCode;
            Timestamp = timestamp;
        }
    }
}
