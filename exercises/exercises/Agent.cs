using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Agent
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Agent(string initialName, string initialLastName ) 
        {
            Name = initialName;
            LastName = initialLastName;
        }

        

        public override string ToString()
        {
            return $"My name is {LastName}. {Name} {LastName}.";
            

        }
    }
}
