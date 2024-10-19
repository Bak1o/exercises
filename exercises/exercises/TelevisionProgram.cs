using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class TelevisionProgram
    {
        public string Name { get; set; }
        public int Duration {  get; set; }
        public TelevisionProgram(string name, int duration) 
        {
            Name = name;
            Duration = duration;
        }
        public void MaxDuration(int maxDuration)
        {
            if (Duration <= maxDuration)
            {
                ToString();
            }
        }

        public override string ToString()
        {
            return Name + " " + Duration;
        }


    }
}
