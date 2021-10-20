using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    abstract public class MonthlySallaryEmployee : Employee
    {
        public double MonthlySallary { get; set; }
        public MonthlySallaryEmployee(string _name,int _age, double _monthlySallary) :base(_name,_age)
        {
            this.MonthlySallary = _monthlySallary;
        }

        override public double GetSalary()
        {
            return this.MonthlySallary;
        }
    }
}
