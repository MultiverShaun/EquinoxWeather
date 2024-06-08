using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquinoxWeather.Infrastructure.Interfaces
{
	public interface IWeatherCode
	{
		string CodeDescription();
		string DayPhotoCreditUrl();
		string DayPhotoDirectUrl();
		string DayPhotoAuthorName();
		string NightPhotoCreditUrl();
		string NightPhotoDirectUrl();
		string NightPhotoAuthorName();
		bool FromUnsplash();
		string WeatherIconDay();
		string WeatherIconNight();
	}
}
