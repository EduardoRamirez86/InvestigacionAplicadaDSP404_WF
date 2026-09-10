using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace InvestigaciónAplicadaDSP404_WF.Models.Dtos
{
    /// <summary>
    /// DTO contenedor para la respuesta del servicio de Geocoding de Open-Meteo.
    /// </summary>
    public class GeocodingApiResponse
    {
        [JsonPropertyName("results")]
        public List<GeocodingItemDto> Results { get; set; } = new List<GeocodingItemDto>();
    }

    /// <summary>
    /// DTO que representa una coincidencia geográfica individual devuelta por la API.
    /// </summary>
    public class GeocodingItemDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("admin1")]
        public string Admin1 { get; set; }
    }
}
