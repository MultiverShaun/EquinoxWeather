using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _53 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Drizzle";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/water-droplets-on-glass-panel-Z7qhxGJzeqk";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/drizzle.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "shark ovski";
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
            return "weather_icons/drizzle.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/drizzle.svg";
        }
    }
}
