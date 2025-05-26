using Newtonsoft.Json;
using EquinoxWeather.Infrastructure.Interfaces;
using EquinoxWeather.Infrastructure.Models.AirQualityData;
using EquinoxWeather.Infrastructure.Models.WeatherData;
using EquinoxWeather.Infrastructure.Models.GeocodingData;
using EquinoxWeather.Services.Managers.WeatherCodes;

namespace EquinoxWeather.Services.Managers
{
	public class Repository : IRepository
	{
		public async Task<OpenMeteoResponse> GetWeather(double latitude, double longitude, bool unitTempIsF, bool unitDistanceIsMph)
		{
            var unitTemp = unitTempIsF ? "&temperature_unit=fahrenheit" : "";
            var unitDistance = unitDistanceIsMph ? "&wind_speed_unit=mph" : "";

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}" +
                      $"&current=temperature_2m,relative_humidity_2m,apparent_temperature,is_day,precipitation,weather_code,cloud_cover,pressure_msl,wind_speed_10m,wind_direction_10m" +
                      $"&hourly=temperature_2m,relative_humidity_2m,dew_point_2m,apparent_temperature,precipitation_probability,weather_code,visibility,uv_index,is_day" +
                      $"&daily=weather_code,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset,uv_index_max,precipitation_sum,precipitation_hours,precipitation_probability_max,wind_speed_10m_max,wind_direction_10m_dominant" +
                      $"{unitTemp}{unitDistance}&timezone=auto&models=best_match";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Could not get weather data. Status code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var weatherDataList = JsonConvert.DeserializeObject<OpenMeteoResponse>(content);

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

            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Could not get AQI data. Status code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var airQualityList = JsonConvert.DeserializeObject<AirQualityIndex>(content);

            if (airQualityList == null)
            {
                throw new Exception("Could not deserialize weather data.");
            }

            return airQualityList;
        }


        private static readonly IDictionary<int, IWeatherCode> WeatherCodes = new Dictionary<int, IWeatherCode>
		{
			{ 0, new _0() },
			{ 1, new _1() },
			{ 2, new _2() },
			{ 3, new _3() },
			{ 45, new _45() },
			{ 48, new _48() },
			{ 51, new _51() },
			{ 53, new _53() },
			{ 55, new _55() },
			{ 56, new _56() },
			{ 57, new _57() },
			{ 61, new _61() },
			{ 63, new _63() },
			{ 65, new _65() },
			{ 66, new _66() },
			{ 67, new _67() },
			{ 71, new _71() },
			{ 73, new _73() },
			{ 75, new _75() },
			{ 77, new _77() },
			{ 80, new _80() },
			{ 81, new _81() },
			{ 82, new _82() },
			{ 85, new _85() },
			{ 86, new _86() },
			{ 95, new _95() },
			{ 96, new _96() },
			{ 99, new _99() },
        };
		public async Task<IWeatherCode> GetWeatherCodeInfo(int weatherCode)
		{
			if (WeatherCodes.TryGetValue(weatherCode, out IWeatherCode weatherCodeInfo))
			{
				return await Task.FromResult(weatherCodeInfo);
			}

			throw new ArgumentException($"Invalid weather code: {weatherCode}");
		}

		public IDictionary<int, IWeatherCode> GetWeatherCodeDictionary()
		{
			return WeatherCodes;
		}

		public async Task<DateTime> GetTimeZoneInfo(string apiTimeZone)
		{
            DateTime utcNow = DateTime.UtcNow;

            // Get the time zone info for the API time zone
            TimeZoneInfo apiTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(apiTimeZone);

            // Convert the UTC time to the API time zone
            DateTime apiTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, apiTimeZoneInfo);

			return await Task.FromResult(apiTime);
        }

		public async Task<string> ParseDegree(int degree)
		{
			if (degree > 337.5) return await Task.FromResult("North");
			if (degree > 292.5) return await Task.FromResult("Northwest");
			if (degree > 247.5) return await Task.FromResult("West");
			if (degree > 202.5) return await Task.FromResult("Southwest");
			if (degree > 157.5) return await Task.FromResult("South");
			if (degree > 122.5) return await Task.FromResult("Southeast");
			if (degree > 67.5) return await Task.FromResult("East");
			if (degree > 22.5) { return await Task.FromResult("Northeast"); }
			else
			{
				return "-";
			}
		}

        public async Task<GeocodingResponse> GetCitySuggestions(string input)
        {
            var url = $"https://geocoding-api.open-meteo.com/v1/search?name={input}&count=5&language=en&format=json";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Could not get city suggestions. Status code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var suggestions = JsonConvert.DeserializeObject<GeocodingResponse>(content);

            if (suggestions == null)
            {
                throw new Exception("Null suggestions.");
            }

            return suggestions;
        }

    }

}
