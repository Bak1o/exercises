using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class FitByte
    {
        public int Age { get; set; }
        public int RestingHeartRate { get; set; }
        public double maxHeartRate { get; private set; }

        public FitByte(int age, int restingHeartRate)
        {
            Age = age;
            RestingHeartRate = restingHeartRate;
            maxHeartRate = 206.3 - (0.711 * age);
        }

        public double TargetRate(double percentageOfMaximum)
        {
            return (maxHeartRate - RestingHeartRate) * percentageOfMaximum + RestingHeartRate;
        }
        public override string ToString()
        {
            return $" max heart rate is {maxHeartRate}";
        }
    }
}
