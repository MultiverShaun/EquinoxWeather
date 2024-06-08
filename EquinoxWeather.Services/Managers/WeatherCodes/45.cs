using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _45 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Fog";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/abstract-painting-37ZuGYD3JOk";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/fog.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Patrick Hendry";
		}
		public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/white-light-on-road-during-night-time-y4EkDeDEoSE";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/fog_night.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "Danila Perevoshchikov";
		}
		public bool FromUnsplash()
		{
			return true;
        }
        public string WeatherIconDay()
        {
            return "weather_icons/fog.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/fog.svg";
        }
    }
}
