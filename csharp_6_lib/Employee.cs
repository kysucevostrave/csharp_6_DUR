using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    abstract public class Employee : Person
    {
        public Employee(string _name, int _age) : base(_name, _age) { }

        public abstract double GetSalary();

        public virtual double GetBonus()
        {
            return 0;
        }

        

        public static bool operator !=(Employee a, Employee b)
        {
            if (a != b)
            {
                return true;
            }
            if (a is null || b is null)
            {
                return false;
            }

            return (a.GetSalary() != b.GetSalary()) ? true : false;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            if (a == b)
            {
                return true;
            }
            if (a is null || b is null)
            {
                return false;
            }
            return (a.GetSalary() == b.GetSalary()) ? true : false;
        }
        public static bool operator <(Employee a, Employee b)
        {
            if (a is null || b is null)
            {
                return false;
            }
            return (a.GetSalary() < b.GetSalary()) ? true : false;
        }
        public static bool operator >(Employee a, Employee b)
        {
            if (a is null || b is null)
            {
                return false;
            }
            return (a.GetSalary() > b.GetSalary()) ? true : false;
        }
    }
}
