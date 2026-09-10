# Weather Desk — Consulta de Clima REST y Persistencia Local
**Universidad Don Bosco (UDB) — Escuela de Computación**  
**Materia:** Desarrollo de Aplicaciones con Software Propietario [DSP404]  
**Actividad:** Investigación Aplicada 2 — Parte II  
**Tecnología:** C# (.NET Framework 4.8) — Windows Forms  

---

### Integrantes del Equipo de Investigación

| No. | Apellido | Nombre | Carnet |
| :---: | :--- | :--- | :---: |
| 1 | Ruiz Hernández | Edgar Antonio | RH201851 |
| 2 | Henriquez Vasquez | Axel Francisco | HV230423 |
| 3 | Varela Linares | Marjorie Daniela | VL261354 |
| 4 | Ramirez Torres | Eduardo Alfredo | RT240549 |
| 5 | Azucena Ayala | Carlos Josue | AA260854 |
| 6 | Ayala Palacios | Marcos Ezequiel | AP260351 |
| 7 | Henriquez Ponce | Diego Noel | HP160046 |

---

## 1. Descripción del Proyecto

**Weather Desk** es una herramienta de escritorio empresarial desarrollada en C# (Windows Forms) que permite a los usuarios consultar información meteorológica actualizada en tiempo real consumiendo la API REST pública de **Open-Meteo** de forma totalmente asíncrona (`async/await`). 

Además, incorpora un subsistema de **persistencia local en archivo CSV** basado en colecciones genéricas (`List<T>`), lo que permite guardar consultas favoritas e inspeccionar su última telemetría incluso en escenarios sin conexión a internet (**Modo Offline**).

---

## 2. Características Principales

* **Búsqueda Geográfica Inteligente con Opciones:** Al escribir el nombre de una ciudad (ej. *Texas*, *San Salvador*, *York*), el sistema consulta Open-Meteo Geocoding y despliega las coincidencias encontradas con su estado/región, país y coordenadas (Latitud/Longitud), permitiendo al usuario seleccionar la ubicación exacta deseada.
* **Coordenadas Explícitas (Latitud y Longitud):** Visualización destacada de latitud y longitud tanto en la tarjeta meteorológica principal como en las columnas dedicadas del `DataGridView`.
* **Consumo Asíncrono de API REST:** Solicitudes HTTP no bloqueantes mediante `HttpClient` con `async/await`, garantizando que la interfaz gráfica permanezca fluida en todo momento.
* **Diseño Profesional de Escritorio:** Interfaz limpia inspirada en Windows 11 con paleta oscura *Dark Slate*, tipografía Segoe UI, controles organizados sin glifos pixelados y retroalimentación de estados en vivo.
* **Persistencia Local y Colecciones Genéricas:**
  - Almacenamiento seguro en archivo plano `favoritos_clima.csv` con codificación UTF-8.
  - Manipulación y gestión en memoria mediante colecciones fuertemente tipadas `List<FavoriteWeatherRecord>`.
  - Carga automática de consultas favoritas al iniciar el programa (`Form_Load`).
  - Capacidad de inspeccionar registros guardados con doble clic en la tabla en modo fuera de línea.
  - Acciones de recarga y eliminación de registros seleccionados.
* **Semilla de Datos Inicial (*Data Seeding*):** Si el archivo CSV no existe, la aplicación genera automáticamente 3 registros iniciales (*San Salvador*, *Madrid*, *Ciudad de México*) para que el usuario pueda validar el funcionamiento offline desde la primera ejecución.
* **Resiliencia y Manejo de Excepciones:** Validaciones tempranas (*fail-fast*), control de timeouts (12s), gestión de errores HTTP y mensajes claros de estado dentro de la interfaz sin interrupciones abruptas.

---

## 3. Arquitectura del Software (N-Layer Desacoplada)

El proyecto respeta los principios **SOLID** y el aislamiento de responsabilidades, evitando concentrar la lógica en el archivo de la interfaz gráfica (*code-behind*):

```text
InvestigaciónAplicadaDSP404_WF/
│
├── Models/                      // [Capa de Dominio] Modelos puros POCO sin dependencias de UI
│   ├── GeoLocation.cs           // Entidad con coordenadas y datos geográficos de la ciudad
│   ├── WeatherCurrentData.cs    // Entidad con mediciones de temperatura, viento y humedad
│   ├── WeatherConditionHelper.cs// Traducción de códigos meteorológicos WMO a español
│   ├── FavoriteWeatherRecord.cs // Modelo de persistencia local con métodos ToCsvLine / FromCsvLine
│   └── Dtos/                    // DTOs para deserialización estricta de JSON
│       ├── GeocodingDtos.cs     // Mapeo para el endpoint de búsqueda geográfica
│       └── ForecastDtos.cs      // Mapeo para el endpoint de telemetría climática
│
├── Interfaces/                  // [Capa de Contratos / Puertos] Abstracciones para desacoplamiento
│   ├── IWeatherApiService.cs    // Contrato para consumo de la API REST
│   └── IFavoriteRepository.cs   // Contrato para almacenamiento local con List<T>
│
├── Services/                    // [Capa de Infraestructura / Red]
│   └── WeatherApiService.cs     // Consumo con HttpClient singleton y System.Text.Json
│
├── Persistence/                 // [Capa de Persistencia Local]
│   └── FavoriteFileRepository.cs// Lectura/escritura CSV asíncrona y sincronización con SemaphoreSlim
│
├── Form1.cs & Form1.Designer.cs // [Capa de Presentación] Formulario Windows Forms y eventos
├── Program.cs                   // Punto de entrada de la aplicación
├── App.config                   // Configuración y redirecciones de ensamblado
└── InvestigaciónAplicadaDSP404_WF.csproj
```

---

## 4. Justificación de Dependencias Externas

### Inclusión de `System.Text.Json` (v8.0.5)
Para cumplir con los requerimientos explícitos de la guía universitaria:
> *"Serialización y deserialización de JSON con System.Text.Json"*

En proyectos basados en **.NET Framework 4.8**, el motor `System.Text.Json` no está incluido por defecto en la BCL heredada (a diferencia de .NET 6/8/9 moderno). Por lo tanto, se incluyó formalmente el paquete oficial mediante NuGet (`PackageReference`).

**Beneficios técnicos:**
1. Deserialización de alto rendimiento orientada a flujos (`Stream`) con consumo de memoria mínimo (`ReadOnlySpan<byte>`).
2. Mayor seguridad frente a inyecciones de tipos en comparación con librerías tradicionales.
3. Cumplimiento estricto de las directrices académicas de la Universidad Don Bosco.

---

## 5. Endpoints de la API REST Utilizados

Se seleccionó **Open-Meteo** debido a que proporciona acceso público, gratuito y libre de claves secretas (*cero credenciales quemadas en el código*):

1. **Búsqueda Geográfica (Geocoding API):**
   ```text
   GET https://geocoding-api.open-meteo.com/v1/search?name={ciudad}&count=1&language=es&format=json
   ```
2. **Consulta Meteorológica en Tiempo Real (Forecast API):**
   ```text
   GET https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relative_humidity_2m,weather_code,wind_speed_10m
   ```

---

## 6. Guía de Ejecución

### Opción A: Desde Visual Studio
1. Abre la solución o el proyecto `InvestigaciónAplicadaDSP404_WF.csproj` en Visual Studio 2019, 2022 o superior.
2. Asegúrate de tener instalado el paquete de desarrollo para **.NET Framework 4.8**.
3. Presiona `F5` o el botón **Iniciar** para restaurar paquetes, compilar y ejecutar la aplicación.

### Opción B: Desde Consola / Terminal
```powershell
# Restaurar dependencias y compilar
& "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe" "InvestigaciónAplicadaDSP404_WF\InvestigaciónAplicadaDSP404_WF.csproj" /t:Restore;Build

# Ejecutar el binario generado
& ".\InvestigaciónAplicadaDSP404_WF\bin\Debug\InvestigaciónAplicadaDSP404_WF.exe"
```
