using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _77 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Snow Grains";
		}
        public string DayPhotoCreditUrl()
        {
            return "https://unsplash.com/photos/photography-of-snow-covered-mountain-at-daytime-0vw4InAC-yM";
        }
        public string DayPhotoDirectUrl()
        {
            return "weather_backgrounds/snow.webp";
        }
        public string DayPhotoAuthorName()
        {
            return "Wladislaw Sokolowskij";
        }
        public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/a-mountain-covered-in-snow-under-a-cloudy-sky-1T97FaKvno8";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/heavy_snow_night.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "Luca Calderone";
		}
		public bool FromUnsplash()
		{
			return true;
        }
        public string WeatherIconDay()
        {
            return "weather_icons/snow_grains.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/snow_grains.svg";
        }
    }
}
