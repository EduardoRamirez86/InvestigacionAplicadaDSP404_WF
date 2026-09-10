using System;

namespace InvestigaciónAplicadaDSP404_WF.Models
{
    /// <summary>
    /// Entidad de dominio que representa una ubicación geográfica obtenida de la búsqueda.
    /// </summary>
    public class GeoLocation
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Admin1 { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GeoLocation()
        {
            Name = string.Empty;
            Country = string.Empty;
            CountryCode = string.Empty;
            Admin1 = string.Empty;
        }

        public GeoLocation(string name, string country, string countryCode, double latitude, double longitude, string admin1 = "")
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Country = country ?? string.Empty;
            CountryCode = countryCode ?? string.Empty;
            Latitude = latitude;
            Longitude = longitude;
            Admin1 = admin1 ?? string.Empty;
        }

        public override string ToString()
        {
            string region = !string.IsNullOrWhiteSpace(Admin1) ? $"{Admin1}, " : "";
            string location = !string.IsNullOrWhiteSpace(Country) ? $"{Name} ({region}{Country})" : Name;
            return $"{location} — Lat: {Latitude:F2}°, Lon: {Longitude:F2}°";
        }
    }
}
