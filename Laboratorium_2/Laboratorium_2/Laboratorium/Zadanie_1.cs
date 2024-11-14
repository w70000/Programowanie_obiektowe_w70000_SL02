using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2.Laboratorium
{
    public class Person
    {

        private string name;
        private string surname;
        private int age;
        private string pesel;


        public string Name { get { return name; } set { name = value + "TEST"; } }
        public string Surname { get { return name; } set { name = value; } }

        public int Age { get { return age; } 
            set{
               if (value > 0) age = value;
               else age = 0;
         }  }

        public Person()
        {
            name = "Test";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public void Welcome(string otherName)
        {
            Console.WriteLine($"Witaj {otherName} Jestem {Name}");
        }

        public void Welcome(int otherName)
        {
            Console.WriteLine($"Witaj {otherName} Jestem {Name}");
        }

    }
}
