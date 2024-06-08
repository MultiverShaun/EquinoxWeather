using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _86 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Heavy Snow Showers";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/house-covered-with-snow-near-mountain-SD68VmEjzdA";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/heavy_snow.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Simon Berger";
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
            return "weather_icons/snow.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/snow.svg";
        }
    }
}
