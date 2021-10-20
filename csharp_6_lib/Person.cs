using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    public class Person
    {
        readonly public string name;
        public int Age { get; set; }

        public Person(string _name, int _age)
        {
            this.name = _name;
            this.Age = _age;
        }
        virtual public void PrintInfo()
        {
            Console.Write("Meno: " + this.name + "  Vek: "+ this.Age);
        }
    }
}
