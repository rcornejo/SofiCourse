using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_basics
{
    class WeatherReport
    {
        public double TempCelsius { get; set; }
        private double TempFarenheit { get; set; }
        public double Wind { get; set; }
        public int Humidity { get; set; }
        public double FeelsLike { get; set; }
        public WeatherReport(double tempCelsius, double tempFarenheit, double wind, int humidity)
        {
            TempCelsius = tempCelsius;
            TempFarenheit = tempFarenheit;
            this.Wind = wind;
            this.Humidity = humidity;
            this.FeelsLike = 0;
        }

        public WeatherReport()
        {
            this.TempCelsius = 0;
            this.TempFarenheit = 0;
            this.Wind = 0;
            this.Humidity = 0;
            this.FeelsLike = 0;
        }
    }
}
