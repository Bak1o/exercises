using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class ClockHand
    {
        public int Value { get; set; }
        public int Limit { get; set; }

        public ClockHand(int limit) 
        {
            Limit = limit;
            Value = 0;
        }

        public void Advance()
        {
            Value++;
            if (Value >= Limit)
            {
                Value = 0;
            }
             

        }

        public void Advance(int increaseNumber)
        {
            Value = Value + increaseNumber;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
