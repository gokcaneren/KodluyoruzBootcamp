using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {
        public int id;
        public string name;
        public string lastName;



        public void welcome(string name, string lastName)
        {
            Console.WriteLine($"Welcome {name} {lastName}");
        }

    }
}
