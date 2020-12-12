using System;

namespace JobApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }


        public int id { get; set; }
        public bool isActive { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public string industry { get; set; }
        public string picture { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string jobDesc { get; set; }
        public DateTime postedOn { get; set; }
    }
}
