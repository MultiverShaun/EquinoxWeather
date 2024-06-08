using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _99
		: IWeatherCode
	{
		public string CodeDescription()
		{
			return "Heavy Hail";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/white-and-gray-stones-on-ground-ERMeJ51f-Ik";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/hail.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Cody A";
		}
		public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/white-and-black-abstract-painting-pWIYmeO0x-s";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/hail_night.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "Marcel Strauß";
		}
		public bool FromUnsplash()
		{
			return true;
        }
        public string WeatherIconDay()
        {
            return "weather_icons/hail.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/hail.svg";
        }
    }
}
