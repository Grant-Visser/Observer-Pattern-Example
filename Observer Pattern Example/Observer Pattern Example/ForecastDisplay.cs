using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example
{
    class ForecastDisplay:Observer,DisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.Out.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.Out.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.Out.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.Out.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
