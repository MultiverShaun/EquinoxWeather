using EquinoxWeather.Infrastructure.Interfaces;

namespace EquinoxWeather.Services.Managers.WeatherCodes
{
    internal record WeatherCodeData(
        string Description,
        string DayCreditUrl,
        string DayDirectUrl,
        string DayAuthor,
        string NightCreditUrl,
        string NightDirectUrl,
        string NightAuthor,
        string IconDay,
        string IconNight
    );

    internal sealed class WeatherCode : IWeatherCode
    {
        private readonly WeatherCodeData _data;
        public WeatherCode(WeatherCodeData data) => _data = data;

        public string CodeDescription()     => _data.Description;
        public string DayPhotoCreditUrl()   => _data.DayCreditUrl;
        public string DayPhotoDirectUrl()   => _data.DayDirectUrl;
        public string DayPhotoAuthorName()  => _data.DayAuthor;
        public string NightPhotoCreditUrl() => _data.NightCreditUrl;
        public string NightPhotoDirectUrl() => _data.NightDirectUrl;
        public string NightPhotoAuthorName()=> _data.NightAuthor;
        public string WeatherIconDay()      => _data.IconDay;
        public string WeatherIconNight()    => _data.IconNight;
    }

    internal static class WeatherCodeRegistry
    {
        public static readonly IReadOnlyDictionary<int, IWeatherCode> All =
            new Dictionary<int, IWeatherCode>
        {
            [0]  = W("Clear",
                     "https://unsplash.com/photos/white-clouds-and-blue-sky--_WOQGNY948",
                     "weather_backgrounds/clear.webp", "Greg Rosenke",
                     "https://unsplash.com/photos/a-group-of-people-standing-on-top-of-a-beach-nHFczgs6ppw",
                     "weather_backgrounds/clear_night.webp", "Jack Cohen",
                     "weather_icons/1_clear.svg", "weather_icons/0_clear.svg"),

            [1]  = W("Mostly Clear",
                     "https://unsplash.com/photos/white-clouds-and-blue-sky-gO11ZsNpCHk",
                     "weather_backgrounds/partly_cloudy.webp", "Monica Toner",
                     "https://unsplash.com/photos/blue-sky-during-night-time-p8NSgvjEk-Y",
                     "weather_backgrounds/partly_cloudy_night.webp", "Olena Bohovyk",
                     "weather_icons/1_partly_cloudy.svg", "weather_icons/0_partly_cloudy.svg"),

            [2]  = W("Partly Cloudy",
                     "https://unsplash.com/photos/white-clouds-and-blue-sky-gO11ZsNpCHk",
                     "weather_backgrounds/partly_cloudy.webp", "Monica Toner",
                     "https://unsplash.com/photos/blue-sky-during-night-time-p8NSgvjEk-Y",
                     "weather_backgrounds/partly_cloudy_night.webp", "Olena Bohovyk",
                     "weather_icons/1_partly_cloudy.svg", "weather_icons/0_partly_cloudy.svg"),

            [3]  = W("Cloudy",
                     "https://unsplash.com/photos/a-plane-flying-through-a-cloudy-blue-sky-Raiv2kwI_7Y",
                     "weather_backgrounds/cloudy.webp", "engin akyurt",
                     "https://unsplash.com/photos/cloudy-day-pBtWrMTop-Q",
                     "weather_backgrounds/cloudy_night.webp", "Francesco Ungaro",
                     "weather_icons/cloudy.svg", "weather_icons/cloudy.svg"),

            [45] = W("Fog",
                     "https://unsplash.com/photos/abstract-painting-37ZuGYD3JOk",
                     "weather_backgrounds/fog.webp", "Patrick Hendry",
                     "https://unsplash.com/photos/white-light-on-road-during-night-time-y4EkDeDEoSE",
                     "weather_backgrounds/fog_night.webp", "Danila Perevoshchikov",
                     "weather_icons/fog.svg", "weather_icons/fog.svg"),

            [48] = W("Freezing Fog",
                     "https://unsplash.com/photos/swan-swimming-on-body-of-water-6te9SupeW1g",
                     "weather_backgrounds/freezing_fog.webp", "Simon Berger",
                     "https://unsplash.com/photos/white-light-on-road-during-night-time-y4EkDeDEoSE",
                     "weather_backgrounds/fog_night.webp", "Danila Perevoshchikov",
                     "weather_icons/fog.svg", "weather_icons/fog.svg"),

            [51] = W("Light Drizzle",
                     "https://unsplash.com/photos/water-droplets-on-glass-panel-Z7qhxGJzeqk",
                     "weather_backgrounds/drizzle.webp", "shark ovski",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/drizzle.svg", "weather_icons/drizzle.svg"),

            [53] = W("Drizzle",
                     "https://unsplash.com/photos/water-droplets-on-glass-panel-Z7qhxGJzeqk",
                     "weather_backgrounds/drizzle.webp", "shark ovski",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/drizzle.svg", "weather_icons/drizzle.svg"),

            [55] = W("Dense Drizzle",
                     "https://unsplash.com/photos/water-droplets-on-glass-panel-Z7qhxGJzeqk",
                     "weather_backgrounds/drizzle.webp", "shark ovski",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/drizzle.svg", "weather_icons/drizzle.svg"),

            [56] = W("Light Freezing Drizzle",
                     "https://unsplash.com/photos/greyscale-photography-of-raccoon-on-open-field-covered-with-snow-during-winter-0QhXAI5bFVM",
                     "weather_backgrounds/freezing_rain.webp", "Jonatan Pie",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/freezing_rain.svg", "weather_icons/freezing_rain.svg"),

            [57] = W("Freezing Drizzle",
                     "https://unsplash.com/photos/greyscale-photography-of-raccoon-on-open-field-covered-with-snow-during-winter-0QhXAI5bFVM",
                     "weather_backgrounds/freezing_rain.webp", "Jonatan Pie",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/freezing_rain.svg", "weather_icons/freezing_rain.svg"),

            [61] = W("Light Rain",
                     "https://unsplash.com/photos/macro-photography-of-water-droplets-on-clear-glass-MU93ZoQPNB8",
                     "weather_backgrounds/rain.webp", "Priscilla Du Preez 🇨🇦",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/rain.svg", "weather_icons/rain.svg"),

            [63] = W("Rain",
                     "https://unsplash.com/photos/macro-photography-of-water-droplets-on-clear-glass-MU93ZoQPNB8",
                     "weather_backgrounds/rain.webp", "Priscilla Du Preez 🇨🇦",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/rain.svg", "weather_icons/rain.svg"),

            [65] = W("Heavy Rain",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/rain.svg", "weather_icons/rain.svg"),

            [66] = W("Freezing Rain",
                     "https://unsplash.com/photos/greyscale-photography-of-raccoon-on-open-field-covered-with-snow-during-winter-0QhXAI5bFVM",
                     "weather_backgrounds/freezing_rain.webp", "Jonatan Pie",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/freezing_rain.svg", "weather_icons/freezing_rain.svg"),

            [67] = W("Heavy Freezing Rain",
                     "https://unsplash.com/photos/greyscale-photography-of-raccoon-on-open-field-covered-with-snow-during-winter-0QhXAI5bFVM",
                     "weather_backgrounds/freezing_rain.webp", "Jonatan Pie",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/freezing_rain.svg", "weather_icons/freezing_rain.svg"),

            [71] = W("Light Snow",
                     "https://unsplash.com/photos/raven-perching-on-black-lumber-ccnfb-cc-30",
                     "weather_backgrounds/light_snow.webp", "Casey Horner",
                     "https://unsplash.com/photos/mountain-with-snow-cap-_lEexUTVsHA",
                     "weather_backgrounds/light_snow_night.webp", "𝗔𝗹𝗲𝘅 𝘙𝘢𝘪𝘯𝘦𝘳",
                     "weather_icons/snow.svg", "weather_icons/snow.svg"),

            [73] = W("Snow",
                     "https://unsplash.com/photos/photography-of-snow-covered-mountain-at-daytime-0vw4InAC-yM",
                     "weather_backgrounds/snow.webp", "Wladislaw Sokolowskij",
                     "https://unsplash.com/photos/a-mountain-covered-in-snow-under-a-cloudy-sky-1T97FaKvno8",
                     "weather_backgrounds/heavy_snow_night.webp", "Luca Calderone",
                     "weather_icons/snow.svg", "weather_icons/snow.svg"),

            [75] = W("Heavy Snow",
                     "https://unsplash.com/photos/house-covered-with-snow-near-mountain-SD68VmEjzdA",
                     "weather_backgrounds/heavy_snow.webp", "Simon Berger",
                     "https://unsplash.com/photos/a-mountain-covered-in-snow-under-a-cloudy-sky-1T97FaKvno8",
                     "weather_backgrounds/heavy_snow_night.webp", "Luca Calderone",
                     "weather_icons/snow.svg", "weather_icons/snow.svg"),

            [77] = W("Snow Grains",
                     "https://unsplash.com/photos/photography-of-snow-covered-mountain-at-daytime-0vw4InAC-yM",
                     "weather_backgrounds/snow.webp", "Wladislaw Sokolowskij",
                     "https://unsplash.com/photos/a-mountain-covered-in-snow-under-a-cloudy-sky-1T97FaKvno8",
                     "weather_backgrounds/heavy_snow_night.webp", "Luca Calderone",
                     "weather_icons/snow_grains.svg", "weather_icons/snow_grains.svg"),

            [80] = W("Light Rain Showers",
                     "https://unsplash.com/photos/macro-photography-of-water-droplets-on-clear-glass-MU93ZoQPNB8",
                     "weather_backgrounds/rain.webp", "Priscilla Du Preez 🇨🇦",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/rain.svg", "weather_icons/rain.svg"),

            [81] = W("Rain Showers",
                     "https://unsplash.com/photos/macro-photography-of-water-droplets-on-clear-glass-MU93ZoQPNB8",
                     "weather_backgrounds/rain.webp", "Priscilla Du Preez 🇨🇦",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/rain.svg", "weather_icons/rain.svg"),

            [82] = W("Heavy Rain Showers",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "https://unsplash.com/photos/dew-drops-on-glass-panel-bWtd1ZyEy6w",
                     "weather_backgrounds/heavy_rain.webp", "Valentin Müller",
                     "weather_icons/rain.svg", "weather_icons/rain.svg"),

            [85] = W("Snow Showers",
                     "https://unsplash.com/photos/raven-perching-on-black-lumber-ccnfb-cc-30",
                     "weather_backgrounds/light_snow.webp", "Casey Horner",
                     "https://unsplash.com/photos/mountain-with-snow-cap-_lEexUTVsHA",
                     "weather_backgrounds/light_snow_night.webp", "𝗔𝗹𝗲𝘅 𝘙𝘢𝘪𝘯𝘦𝘳",
                     "weather_icons/snow.svg", "weather_icons/snow.svg"),

            [86] = W("Heavy Snow Showers",
                     "https://unsplash.com/photos/house-covered-with-snow-near-mountain-SD68VmEjzdA",
                     "weather_backgrounds/heavy_snow.webp", "Simon Berger",
                     "https://unsplash.com/photos/a-mountain-covered-in-snow-under-a-cloudy-sky-1T97FaKvno8",
                     "weather_backgrounds/heavy_snow_night.webp", "Luca Calderone",
                     "weather_icons/snow.svg", "weather_icons/snow.svg"),

            [95] = W("Thunderstorms",
                     "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo",
                     "weather_backgrounds/thunderstorm.webp", "Michelle McEwen",
                     "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo",
                     "weather_backgrounds/thunderstorm.webp", "Michelle McEwen",
                     "weather_icons/thunderstorm.svg", "weather_icons/thunderstorm.svg"),

            [96] = W("Thunderstorms, Light Hail",
                     "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo",
                     "weather_backgrounds/thunderstorm.webp", "Michelle McEwen",
                     "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo",
                     "weather_backgrounds/thunderstorm.webp", "Michelle McEwen",
                     "weather_icons/thunderstorm.svg", "weather_icons/thunderstorm.svg"),

            [99] = W("Thunderstorms, Hail",
                     "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo",
                     "weather_backgrounds/thunderstorm.webp", "Michelle McEwen",
                     "https://unsplash.com/photos/black-and-white-abstract-painting-sCrqMG2f6qo",
                     "weather_backgrounds/thunderstorm.webp", "Michelle McEwen",
                     "weather_icons/thunderstorm.svg", "weather_icons/thunderstorm.svg"),
        };

        private static IWeatherCode W(
            string desc,
            string dayCreditUrl, string dayDirect, string dayAuthor,
            string nightCreditUrl, string nightDirect, string nightAuthor,
            string iconDay, string iconNight) =>
            new WeatherCode(new WeatherCodeData(
                desc,
                dayCreditUrl, dayDirect, dayAuthor,
                nightCreditUrl, nightDirect, nightAuthor,
                iconDay, iconNight));
    }
}
