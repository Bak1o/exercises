using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Timer
    {
        private ClockHand _hundredthsofSecond;
        private ClockHand _seconds;

        public Timer()
        {
            _hundredthsofSecond = new ClockHand(100);
            _seconds = new ClockHand(60);
        }

        public void Advance()
        {
            _hundredthsofSecond.Advance();
            //_hundredthsofSecond.Value = _hundredthsofSecond.Value + 9;
            _hundredthsofSecond.Advance(9);
            
            if (_hundredthsofSecond.Value >= 100)
            {
                _hundredthsofSecond.Value = 0;
                _seconds.Advance();
            }
        }

        public override string ToString()
        {
            return $" {_seconds.Value} : {_hundredthsofSecond.Value} ";
        }


    }
}
