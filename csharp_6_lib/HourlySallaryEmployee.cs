using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    abstract public class HourlySallaryEmployee : Employee
    {

        public double HourlySallary { get; set; }
        public int HoursWorked { get; set; }
        public HourlySallaryEmployee(string _name, int _age, double _hourlySallary) : base(_name, _age)
        {
            this.HourlySallary = _hourlySallary;
            this.HoursWorked = 5;
        }

        override public double GetSalary()
        {
            return this.HoursWorked * this.HourlySallary + this.GetBonus();
        }
    }
}
