using System.Text.Json.Serialization;

namespace InvestigaciónAplicadaDSP404_WF.Models.Dtos
{
    /// <summary>
    /// DTO contenedor para la respuesta del pronóstico del tiempo de Open-Meteo.
    /// </summary>
    public class WeatherForecastApiResponse
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("current")]
        public CurrentWeatherDto Current { get; set; }
    }

    /// <summary>
    /// DTO que mapea el objeto "current" con las mediciones climáticas del momento.
    /// </summary>
    public class CurrentWeatherDto
    {
        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("temperature_2m")]
        public double Temperature2m { get; set; }

        [JsonPropertyName("relative_humidity_2m")]
        public int RelativeHumidity2m { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public double WindSpeed10m { get; set; }

        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }
    }
}
