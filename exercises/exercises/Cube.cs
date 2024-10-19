using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Cube
    {
        public int EdgeLength {  get; set; }
        public int volume { get; private set; }
        public Cube(int edgeLength)
        {
            EdgeLength = edgeLength;
            //volume = edgeLength * edgeLength * edgeLength;
            
        }
        public int Volume()
        {
             volume = EdgeLength * EdgeLength * EdgeLength;
            return volume;
        }
        
        public override string ToString()
        {
            return $" the edge is {EdgeLength} and volume is {volume} ";
        }
    }
}
