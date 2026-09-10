using System.Collections.Generic;
using System.Threading.Tasks;
using InvestigaciónAplicadaDSP404_WF.Models;

namespace InvestigaciónAplicadaDSP404_WF.Interfaces
{
    /// <summary>
    /// Puerto / Contrato para la persistencia local de consultas favoritas en archivo utilizando List&lt;T&gt;.
    /// </summary>
    public interface IFavoriteRepository
    {
        /// <summary>
        /// Ruta física del archivo de persistencia local en disco.
        /// </summary>
        string FilePath { get; }

        /// <summary>
        /// Carga todas las consultas guardadas localmente en una lista genérica List&lt;FavoriteWeatherRecord&gt;.
        /// </summary>
        Task<List<FavoriteWeatherRecord>> GetAllAsync();

        /// <summary>
        /// Agrega o actualiza una consulta meteorológica favorita en la persistencia local.
        /// </summary>
        Task SaveAsync(FavoriteWeatherRecord record);

        /// <summary>
        /// Guarda en lote la colección de favoritos en el archivo local.
        /// </summary>
        Task SaveAllAsync(List<FavoriteWeatherRecord> records);

        /// <summary>
        /// Elimina una consulta favorita por el nombre de la ciudad.
        /// </summary>
        Task<bool> DeleteAsync(string cityName);
    }
}
