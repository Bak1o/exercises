using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class DecreasingCount
    {
        private int _value;
        public DecreasingCount(int initialValue)
        {
            if (initialValue < 0)
            {
                initialValue = 0;
            }
            _value = initialValue;
        }
        public void PrintValue()
        {
            Console.WriteLine(_value);
        }

        public void Decreament()
        {
            if (_value <= 0)
            {
                _value = 0;
            }
            else
            { 
            _value--;
            }
            
        }

        public void Reset() 
        {
            _value = 0; 
        }

    }
}
