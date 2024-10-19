using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public PersonalInformation(string firstName, string lastName, int id) 
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
        public override string ToString()
        {
            return FirstName +" " + LastName;
        }


    }
}
