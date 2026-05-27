using EquinoxWeather.Infrastructure.Models.AirQualityData;
using EquinoxWeather.Infrastructure.Models.WeatherData;
using EquinoxWeather.Infrastructure.Models.GeocodingData;

namespace EquinoxWeather.Infrastructure.Interfaces
{
    public interface IRepository
	{
		Task<OpenMeteoResponse> GetWeather(double latitude, double longitude, bool unitTempIsF, bool unitDistanceIsMph);
        Task<AirQualityIndex> GetAirQuality(double latitude, double longitude);
        IWeatherCode GetWeatherCodeInfo(int weatherCode);
		IDictionary<int, IWeatherCode> GetWeatherCodeDictionary();
		DateTime GetTimeZoneInfo(string apiTimeZone);
		string ParseDegree(int degree);
        Task<GeocodingResponse> GetCitySuggestions(string input);


    }
}
