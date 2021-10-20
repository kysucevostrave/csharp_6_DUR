using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    public class Manager : MonthlySallaryEmployee
    {
        public Manager(string _name, int _age) : base(_name, _age, 80000) { }

        override public double GetSalary()
        {
            return this.MonthlySallary + this.Age * 500 + GetBonus();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write(" Pozice: manager");
        }
    }
}
