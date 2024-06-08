using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _0 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Clear";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/white-clouds-and-blue-sky--_WOQGNY948";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/clear.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Greg Rosenke";
		}
        public string NightPhotoCreditUrl()
        {
            return "https://unsplash.com/photos/a-group-of-people-standing-on-top-of-a-beach-nHFczgs6ppw";
        }
        public string NightPhotoDirectUrl()
        {
            return "weather_backgrounds/clear_night.webp";
        }
        public string NightPhotoAuthorName()
        {
            return "Jack Cohen";
        }
        public bool FromUnsplash()
		{
			return true;
		}

		public string WeatherIconDay()
		{
			return "weather_icons/1_clear.svg";
		}

        public string WeatherIconNight()
        {
            return "weather_icons/0_clear.svg";
        }
    }
}
