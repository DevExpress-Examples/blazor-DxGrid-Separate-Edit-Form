using System;

namespace DataGridSeparateEditForm.Data
{
    public class WeatherForecast
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public double TemperatureF => Math.Round((TemperatureC * 1.8 + 32), 2);

        public string Summary { get; set; }
    }
}
