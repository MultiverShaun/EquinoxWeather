using EquinoxWeather;
using EquinoxWeather.Infrastructure.Interfaces;
using EquinoxWeather.Services.Managers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EquinoxWeather.Infrastructure.Models.CityState;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddSingleton<CityState>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
