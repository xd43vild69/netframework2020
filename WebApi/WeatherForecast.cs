using System;

namespace WebApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Concept
    {
        public int Id { get; set; }
        public string concept { get; set; }
        public string definition { get; set; }
    }
}
