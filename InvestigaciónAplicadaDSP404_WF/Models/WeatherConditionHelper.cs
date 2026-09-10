using System.Collections.Generic;

namespace InvestigaciónAplicadaDSP404_WF.Models
{
    /// <summary>
    /// Utilidad de dominio para mapear códigos WMO de Open-Meteo a descripciones legibles en español.
    /// </summary>
    public static class WeatherConditionHelper
    {
        private static readonly Dictionary<int, string> Descriptions = new Dictionary<int, string>
        {
            { 0, "Cielo despejado" },
            { 1, "Mayormente despejado" },
            { 2, "Parcialmente nublado" },
            { 3, "Nublado" },
            { 45, "Niebla" },
            { 48, "Niebla con escarcha" },
            { 51, "Llovizna ligera" },
            { 53, "Llovizna moderada" },
            { 55, "Llovizna densa" },
            { 56, "Llovizna helada ligera" },
            { 57, "Llovizna helada densa" },
            { 61, "Lluvia ligera" },
            { 63, "Lluvia moderada" },
            { 65, "Lluvia fuerte" },
            { 66, "Lluvia helada ligera" },
            { 67, "Lluvia helada fuerte" },
            { 71, "Nevada ligera" },
            { 73, "Nevada moderada" },
            { 75, "Nevada fuerte" },
            { 77, "Granos de nieve" },
            { 80, "Chubascos ligeros" },
            { 81, "Chubascos moderados" },
            { 82, "Chubascos violentos" },
            { 85, "Chubascos de nieve ligeros" },
            { 86, "Chubascos de nieve fuertes" },
            { 95, "Tormenta eléctrica" },
            { 96, "Tormenta con granizo ligero" },
            { 99, "Tormenta con granizo fuerte" }
        };

        public static string GetDescription(int weatherCode)
        {
            return Descriptions.TryGetValue(weatherCode, out var desc) ? desc : "Condición variable";
        }
    }
}
