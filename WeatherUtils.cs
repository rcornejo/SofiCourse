using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_basics
{
    static class WeatherUtils
    {
        private const double C1 = -42.379;
        private const double C2 = 2.04901523;
        private const double C3 = 10.14333127;
        private const double C4 = -0.22475541;
        private const double C5 = -6.83783E-3;
        private const double C6 = -5.481717E-2;
        private const double C7 = 1.22874E-3;
        private const double C8 = 8.5282E-4;
        private const double C9 = -1.99E-6;

        public static double ToFarenheit(double celsiusTemp)
        {
            return (celsiusTemp * 1.8) + 32;
        }
        public static double ToCelsius(double tempFarenheit)
        {
            return (tempFarenheit - 32) / 1.8;
        }
        //Funciona para temeperaturas mayores o iguales a 27 grados
        //Con una precisión de 0.7°C
        //https://www.wpc.ncep.noaa.gov/html/heatindex.shtml
        public static double getFeelsLike(double celsiusTemp, int humidity)
        {
            double heathIndex = Double.NegativeInfinity;
            //Convertir a °F que es lo que usa la formula
            double T = ToFarenheit(celsiusTemp);
            int R = humidity;
            //Calcular el indice de calor que es la sensación térmica en °F
            heathIndex = C1 + (C2 * T) + (C3 * R) + (C4 * T * R) + (C5 * T * T) + (C6 * R * R) + (C7 * T * T * R) + (C8 * T * R * R) + (C9 * T * T * R * R);
            //Convertir a °C
            double c = ToCelsius(heathIndex);
            return Math.Round(c);
        }
    }
}
