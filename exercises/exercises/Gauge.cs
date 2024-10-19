using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Gauge
    {
        public int value {  get; set; } 

        public Gauge() 
        {
            value = 0;
        }

        public void Increase()
        {
            
            
                value++;
            

        }

        public void Decrease() 
        {
            if (value > 0)
            {
                value--;
            }
        
        }

        public bool IsFull()
        {
            if (value == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
