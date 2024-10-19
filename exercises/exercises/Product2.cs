using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Product2
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Weight { get; set; }

        public Product2(string name)
        {
            Name = name;
            Location = " shelf ";
            Weight = 1;
        }
        public Product2(string name, string location)
        {
            Name = name;
            Location = location;
            Weight = 1;

        }

        public Product2(string name, string location, int weight) : this(name, location)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $" name {Name}, location {Location}, Weight {Weight} ";
        }
    }
}
