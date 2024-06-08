using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _48 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Freezing Fog";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/swan-swimming-on-body-of-water-6te9SupeW1g";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/freezing_fog.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Simon Berger";
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
