using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _1 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Mostly Clear";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/white-clouds-and-blue-sky-gO11ZsNpCHk";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/partly_cloudy.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Monica Toner";
		}

        public string NightPhotoCreditUrl()
        {
            return "https://unsplash.com/photos/blue-sky-during-night-time-p8NSgvjEk-Y";
        }
        public string NightPhotoDirectUrl()
        {
            return "weather_backgrounds/partly_cloudy_night.webp";
        }
        public string NightPhotoAuthorName()
        {
            return "Olena Bohovyk";
        }
        public bool FromUnsplash()
		{
			return true;
		}
        public string WeatherIconDay()
        {
			return "weather_icons/1_partly_cloudy.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/0_partly_cloudy.svg";
        }
    }
}
