using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridSeparateEditForm.Data
{
    public class WeatherForecastService
    {
        private static string[] Summaries = new[]
        {
            "Hot", "Warm", "Cold", "Freezing"
        };

        private List<WeatherForecast> CreateForecast()
        {
            var rng = new Random();
            DateTime startDate = DateTime.Now;
            return Enumerable.Range(1, 15).Select(index => new WeatherForecast
            {
                ID = index,
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
        }

        private List<WeatherForecast> Forecasts { get; set; }
        public WeatherForecastService()
        {
            Forecasts = CreateForecast();
        }
        public Task<WeatherForecast[]> GetForecastAsync()
        {
            return Task.FromResult(Forecasts.ToArray());
        }
        public Task<WeatherForecast> GetForecastByIdAsync(int id)
        {
            return Task.FromResult(Forecasts.Where(m => m.ID == id).FirstOrDefault());
        }
        public Task<string[]> GetSummariesAsync()
        {
            return Task.FromResult(Summaries);
        }
        WeatherForecast[] UpdateInternal(WeatherForecast dataItem, WeatherForecast newDataItem)
        {
            dataItem.Date = newDataItem.Date;
            dataItem.TemperatureC = newDataItem.TemperatureC;
            dataItem.Summary = newDataItem.Summary;
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Update(WeatherForecast dataItem, WeatherForecast newDataItem)
        {
            return Task.FromResult(UpdateInternal(dataItem, newDataItem));
        }
    }
}
