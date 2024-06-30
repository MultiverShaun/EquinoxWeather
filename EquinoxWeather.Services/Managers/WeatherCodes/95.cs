﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
	public class _95 : IWeatherCode
	{
		public string CodeDescription()
		{
			return "Thunderstorms";
		}
		public string DayPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo";
		}
		public string DayPhotoDirectUrl()
		{
			return "weather_backgrounds/thunderstorm.webp";
		}
		public string DayPhotoAuthorName()
		{
			return "Michelle McEwen";
		}
		public string NightPhotoCreditUrl()
		{
			return "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo";
		}
		public string NightPhotoDirectUrl()
		{
			return "weather_backgrounds/thunderstorm.webp";
		}
		public string NightPhotoAuthorName()
		{
			return "Michelle McEwen";
		}
		public bool FromUnsplash()
		{
			return true;
        }
        public string WeatherIconDay()
        {
            return "weather_icons/thunderstorm.svg";
        }

        public string WeatherIconNight()
        {
            return "weather_icons/thunderstorm.svg";
        }
    }
}
