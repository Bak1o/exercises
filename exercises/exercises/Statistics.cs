using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Statistics
    {
        public int Count { get; set; }  
        public int Sum { get; set; }
        public Statistics() 
        {
            Count = 0;
            
            Sum = 0;
            
        }

        public void AddNumber(int value)
        {
            
            Count++;
            Sum = Sum + value;
            
        }
    }
}
