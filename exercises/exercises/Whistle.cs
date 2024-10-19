using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Whistle
    {
        private string _sound;
        public Whistle(string whistleSound) 
        {
            _sound = whistleSound;
        }

        public override string ToString()
        {
            return _sound;
        }

    }
}
