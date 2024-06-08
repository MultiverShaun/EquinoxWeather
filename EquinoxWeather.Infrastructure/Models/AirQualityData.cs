namespace EquinoxWeather.Infrastructure.Models.AirQualityData
{
    public class AirQualityIndex
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
    }

    public class CurrentUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string us_aqi { get; set; }
        public string pm10 { get; set; }
        public string pm2_5 { get; set; }
        public string carbon_monoxide { get; set; }
        public string nitrogen_dioxide { get; set; }
        public string sulphur_dioxide { get; set; }
        public string ozone { get; set; }
    }

    public class CurrentData
    {
        public string time { get; set; }
        public int interval { get; set; }
        public int us_aqi { get; set; }
        public double pm10 { get; set; }
        public double pm2_5 { get; set; }
        public double carbon_monoxide { get; set; }
        public double nitrogen_dioxide { get; set; }
        public double sulphur_dioxide { get; set; }
        public double ozone { get; set; }
    }

}
