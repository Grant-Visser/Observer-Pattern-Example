using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example
{
    class StatisticsDisplay: Observer, DisplayElement
    {
        private float maxTemp = 0;
        private float minTemp = 500;
        private float sumTemp = 0;
        private int numReadings = 0;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            sumTemp += temp;
            numReadings++;
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp<minTemp)
            {
                minTemp = temp;
            }
            Display();
        }

        public void Display()
        {
            Console.Out.WriteLine("Avg/Max/Min temperature = " + (sumTemp / numReadings) + "/" + maxTemp + "/" + minTemp);
        }
    }
}
