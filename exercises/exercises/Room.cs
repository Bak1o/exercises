using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Room
    {
        private string _code;
        private int _seats;
        
        public Room(string classCode, int numberOfSits)
        {
            _code = classCode;
            _seats = numberOfSits;
        }
    }
}
