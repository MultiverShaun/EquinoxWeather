using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _71 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Light Snow";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/raven-perching-on-black-lumber-ccnfb-cc-30";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/light_snow.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Casey Horner";
		}
		public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/mountain-with-snow-cap-_lEexUTVsHA";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/light_snow_night.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "𝗔𝗹𝗲𝘅 𝘙𝘢𝘪𝘯𝘦𝘳";
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
