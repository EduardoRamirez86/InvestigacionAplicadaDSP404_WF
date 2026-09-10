using System.Threading;
using System.Threading.Tasks;
using InvestigaciónAplicadaDSP404_WF.Models;

namespace InvestigaciónAplicadaDSP404_WF.Interfaces
{
    /// <summary>
    /// Puerto / Contrato para el consumo asíncrono del servicio web meteorológico.
    /// </summary>
    public interface IWeatherApiService
    {
        /// <summary>
        /// Busca las opciones de ciudades coincidentes con sus coordenadas (latitud/longitud) por nombre.
        /// </summary>
        Task<System.Collections.Generic.List<GeoLocation>> SearchCitiesAsync(string cityName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Busca la primera coincidencia geográfica de una ciudad por su nombre.
        /// </summary>
        Task<GeoLocation> SearchCityAsync(string cityName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Obtiene las métricas climáticas actuales dadas una latitud y longitud.
        /// </summary>
        Task<WeatherCurrentData> GetCurrentWeatherAsync(double latitude, double longitude, CancellationToken cancellationToken = default);
    }
}
