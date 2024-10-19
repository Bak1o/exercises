using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Item
    {
        public string Name { get; set; }
        public string Create { get; set; }

        public Item(string name)
        {
            Name = name;
            Create = DateTime.Now.ToString("F");

        }

        public override string ToString()
        {

            return "  the name is : " + Name + ", Create time : " + Create ;
                

        }

    }
}
