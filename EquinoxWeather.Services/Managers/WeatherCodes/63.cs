using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _63 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Rain";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/macro-photography-of-water-droplets-on-clear-glass-MU93ZoQPNB8";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/rain.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Priscilla Du Preez 🇨🇦";
		}
		public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/heavy_rain.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "Valentin Müller";
		}
		public bool FromUnsplash()
		{
			return true;
        }
        public string WeatherIconDay()
        {
            return "weather_icons/rain.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/rain.svg";
        }
    }
}
