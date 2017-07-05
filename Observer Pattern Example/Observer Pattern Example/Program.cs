using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(wd);
            StatisticsDisplay sd = new StatisticsDisplay(wd);
            ForecastDisplay fd = new ForecastDisplay(wd);

            for (int i = 0; i <= 100; i++)
            {
                int temp = new Random(i-1).Next(100);
                int humidity = new Random(i-2).Next(100);
                int pressure = new Random(i).Next(100);
                wd.SetMeasurements(temp,humidity,pressure);
            }

            Console.Out.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
