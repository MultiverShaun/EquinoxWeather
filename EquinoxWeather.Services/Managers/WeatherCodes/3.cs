using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _3 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Cloudy";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/a-plane-flying-through-a-cloudy-blue-sky-Raiv2kwI_7Y";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/cloudy.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "engin akyurt";
		}
		public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/cloudy-day-pBtWrMTop-Q";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/cloudy_night.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "Francesco Ungaro";
		}
		public bool FromUnsplash()
		{
			return true;
        }
        public string WeatherIconDay()
        {
            return "weather_icons/cloudy.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/cloudy.svg";
        }
    }
}
