using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example
{
    class CurrentConditionsDisplay: Observer, DisplayElement
    {
        private float temp;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.Out.WriteLine("Current conditions: " + temp + "c degrees and " + humidity + "% humidity");
        }
    }
}
