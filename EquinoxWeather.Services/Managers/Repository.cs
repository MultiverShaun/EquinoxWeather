using System.Text.Json;
using EquinoxWeather.Infrastructure.Interfaces;
using EquinoxWeather.Infrastructure.Models.AirQualityData;
using EquinoxWeather.Infrastructure.Models.WeatherData;
using EquinoxWeather.Infrastructure.Models.GeocodingData;
using EquinoxWeather.Services.Managers.WeatherCodes;

namespace EquinoxWeather.Services.Managers
{
	public class Repository : IRepository
	{
		private readonly HttpClient _http;
		private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

		public Repository(HttpClient http) => _http = http;

		public async Task<OpenMeteoResponse> GetWeather(double latitude, double longitude, bool unitTempIsF, bool unitDistanceIsMph)
		{
            var unitTemp = unitTempIsF ? "&temperature_unit=fahrenheit" : "";
            var unitDistance = unitDistanceIsMph ? "&wind_speed_unit=mph" : "";

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                      $"&current=temperature_2m,relative_humidity_2m,apparent_temperature,is_day,precipitation,weather_code,cloud_cover,pressure_msl,wind_speed_10m,wind_direction_10m" +
                      $"&hourly=temperature_2m,relative_humidity_2m,dew_point_2m,apparent_temperature,precipitation_probability,weather_code,visibility,uv_index,is_day" +
                      $"&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset,uv_index_max,precipitation_sum,precipitation_hours,precipitation_probability_max,wind_speed_10m_max,wind_direction_10m_dominant" +
                      $"{unitTemp}{unitDistance}&timezone=auto&models=best_match";

            var response = await _http.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Could not get weather data. Status code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var weatherDataList = JsonSerializer.Deserialize<OpenMeteoResponse>(content, JsonOptions);

            if (weatherDataList == null)
            {
                throw new Exception("Could not deserialize weather data.");
            }

            return weatherDataList;
        }

        public async Task<AirQualityIndex> GetAirQuality(double latitude, double longitude)
        {
            var url = $"https://air-quality-api.open-meteo.com/v1/air-quality?latitude={latitude}&longitude={longitude}" +
                      $"&current=us_aqi,pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,sulphur_dioxide,ozone";

            var response = await _http.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Could not get AQI data. Status code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var airQualityList = JsonSerializer.Deserialize<AirQualityIndex>(content, JsonOptions);

            if (airQualityList == null)
            {
                throw new Exception("Could not deserialize weather data.");
            }

            return airQualityList;
        }


		public IWeatherCode GetWeatherCodeInfo(int weatherCode)
		{
			if (WeatherCodeRegistry.All.TryGetValue(weatherCode, out IWeatherCode weatherCodeInfo))
				return weatherCodeInfo;

			throw new ArgumentException($"Invalid weather code: {weatherCode}");
		}

		public IDictionary<int, IWeatherCode> GetWeatherCodeDictionary()
		{
			return WeatherCodeRegistry.All.ToDictionary(k => k.Key, v => v.Value);
		}

		public DateTime GetTimeZoneInfo(string apiTimeZone)
		{
			var tz = TimeZoneInfo.FindSystemTimeZoneById(apiTimeZone);
			return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
		}

		public string ParseDegree(int degree)
		{
			if (degree > 337.5) return "North";
			if (degree > 292.5) return "Northwest";
			if (degree > 247.5) return "West";
			if (degree > 202.5) return "Southwest";
			if (degree > 157.5) return "South";
			if (degree > 122.5) return "Southeast";
			if (degree > 67.5)  return "East";
			if (degree > 22.5)  return "Northeast";
			return "-";
		}

        public async Task<GeocodingResponse> GetCitySuggestions(string input)
        {
            var url = $"https://geocoding-api.open-meteo.com/v1/search?name={input}&count=5&language=en&format=json";

            var response = await _http.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Could not get city suggestions. Status code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var suggestions = JsonSerializer.Deserialize<GeocodingResponse>(content, JsonOptions);

            if (suggestions == null)
            {
                throw new Exception("Null suggestions.");
            }

            return suggestions;
        }

    }

}
