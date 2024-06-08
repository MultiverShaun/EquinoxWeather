using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _67 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Heavy Freezing Rain";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/greyscale-photography-of-raccoon-on-open-field-covered-with-snow-during-winter-0QhXAI5bFVM";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/freezing_rain.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Jonatan Pie";
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
            return "weather_icons/freezing_rain.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/freezing_rain.svg";
        }
    }
}
