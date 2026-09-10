# Weather Desk — Consulta de Clima REST y Persistencia Local
**Universidad Don Bosco (UDB) — Escuela de Computación**  
**Materia:** Desarrollo de Aplicaciones con Software Propietario [DSP404]  
**Actividad:** Investigación Aplicada 2 — Parte II  
**Tecnología:** C# (.NET Framework 4.8) — Windows Forms  

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

---

## 7. Preparación para la Defensa Individual (20%)

Preguntas técnicas clave evaluadas por el docente y sus fundamentos:

1. **¿Por qué se debe usar `async/await` al invocar servicios web en Windows Forms?**  
   *Respuesta:* Windows Forms ejecuta la interfaz de usuario en un único hilo principal (*UI Thread*). Si se realiza una llamada HTTP sincrónica (o usando `.Result`/`.Wait()`), el hilo de la interfaz se bloquea esperando la respuesta del servidor, provocando que la ventana quede congelada (*"No responde"*). Al usar `async/await`, el hilo de UI queda liberado para redibujar controles y responder al usuario mientras la petición I/O se procesa en segundo plano.

2. **¿Por qué se implementó `HttpClient` como una instancia estática única (Singleton)?**  
   *Respuesta:* Crear una nueva instancia de `HttpClient` con cada solicitud dentro de un bloque `using` provoca el agotamiento de sockets (*socket exhaustion*) a nivel de sistema operativo. Aunque el objeto se destruya en C#, los sockets TCP subyacentes permanecen retenidos durante varios minutos en estado `TIME_WAIT`. Una instancia compartida y reutilizable optimiza el uso de conexiones y recursos del sistema.

3. **¿Cómo se garantiza la persistencia local de favoritos con colecciones genéricas?**  
   *Respuesta:* Se emplea la colección genérica `List<FavoriteWeatherRecord>`. Al iniciar la aplicación (`Form_Load`), el repositorio lee asíncronamente el archivo CSV y carga los registros en memoria. Cuando el usuario guarda o elimina un favorito, la lista se actualiza y se sincroniza en el archivo físico en formato delimitado por comas con codificación UTF-8.

4. **¿Por qué la arquitectura utiliza interfaces (`IWeatherApiService`, `IFavoriteRepository`)?**  
   *Respuesta:* En cumplimiento con el principio de Inversión de Dependencias (DIP de SOLID), la interfaz gráfica no debe acoplarse rígidamente a implementaciones concretas. Esto permite sustituir el servicio real por un doble de prueba (*mock*) para pruebas unitarias sin depender de la conexión a internet y facilita cambiar el motor de almacenamiento (por ejemplo, de CSV a SQLite) sin tocar el código de la UI.
