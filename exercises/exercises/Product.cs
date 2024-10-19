using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Product
    {
        public double Price {  get; set; }
        public int Quantity { get; set; }
        public string Name {  get; set; }

        public Product(double price, int quantity, string name) 
        {
            Price = price;
            Quantity = quantity;
            Name = name;
        
        }
        public override string ToString()
        { 
        return $"{Name} : {Price} : {Quantity} pcs";
        }

    }
}
