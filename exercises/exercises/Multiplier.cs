using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Multiplier
    {
        public int MultiplierNumber {  get; set; }

        public Multiplier(int initialMultiplier) 
        {
            MultiplierNumber = initialMultiplier;

        }

        public int Multiply(int number)
        {
            return MultiplierNumber = MultiplierNumber * number;
        }

    }
}
