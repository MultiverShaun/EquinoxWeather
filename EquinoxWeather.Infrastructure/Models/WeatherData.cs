namespace EquinoxWeather.Infrastructure.Models.WeatherData
{
    public class OpenMeteoResponse
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public CurrentUnits current_units { get; set; }
        public CurrentData current { get; set; }
        public HourlyUnits hourly_units { get; set; }
        public Hourly hourly { get; set; }
        public DailyUnits daily_units { get; set; }
        public Daily daily { get; set; }
    }

    public class CurrentUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string relative_humidity_2m { get; set; }
        public string apparent_temperature { get; set; }
        public string is_day { get; set; }
        public string precipitation { get; set; }
        public string weather_code { get; set; }
        public string cloud_cover { get; set; }
        public string pressure_msl { get; set; }
        public string wind_speed_10m { get; set; }
        public string wind_direction_10m { get; set; }
    }

    public class CurrentData
    {
        public string time { get; set; }
        public int interval { get; set; }
        public double temperature_2m { get; set; }
        public int relative_humidity_2m { get; set; }
        public double apparent_temperature { get; set; }
        public int is_day { get; set; }
        public double precipitation { get; set; }
        public int weather_code { get; set; }
        public int cloud_cover { get; set; }
        public double pressure_msl { get; set; }
        public double wind_speed_10m { get; set; }
        public int wind_direction_10m { get; set; }
    }

    public class HourlyUnits
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
        public string relative_humidity_2m { get; set; }
        public string dew_point_2m { get; set; }
        public string apparent_temperature { get; set; }
        public string precipitation_probability { get; set; }
        public string weather_code { get; set; }
        public string visibility { get; set; }
        public string uv_index { get; set; }
        public string is_day { get; set; }
    }

    public class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
        public List<int> relative_humidity_2m { get; set; }
        public List<double> dew_point_2m { get; set; }
        public List<double> apparent_temperature { get; set; }
        public List<int> precipitation_probability { get; set; }
        public List<int> weather_code { get; set; }
        public List<double> visibility { get; set; }
        public List<double> uv_index { get; set; }
        public List<int> is_day { get; set; }
    }

    public class DailyUnits
    {
        public string time { get; set; }
        public string weather_code { get; set; }
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
        public string apparent_temperature_max { get; set; }
        public string apparent_temperature_min { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string uv_index_max { get; set; }
        public string precipitation_sum { get; set; }
        public string precipitation_hours { get; set; }
        public string precipitation_probability_max { get; set; }
        public string wind_speed_10m_max { get; set; }
        public string wind_direction_10m_dominant { get; set; }
    }

    public class Daily
    {
        public List<string> time { get; set; }
        public List<int> weather_code { get; set; }
        public List<double> temperature_2m_max { get; set; }
        public List<double> temperature_2m_min { get; set; }
        public List<double> apparent_temperature_max { get; set; }
        public List<double> apparent_temperature_min { get; set; }
        public List<string> sunrise { get; set; }
        public List<string> sunset { get; set; }
        public List<double> uv_index_max { get; set; }
        public List<double> precipitation_sum { get; set; }
        public List<double> precipitation_hours { get; set; }
        public List<int> precipitation_probability_max { get; set; }
        public List<double> wind_speed_10m_max { get; set; }
        public List<int> wind_direction_10m_dominant { get; set; }
    }
}
