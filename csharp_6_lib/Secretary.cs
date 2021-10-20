using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    public class Secretary : MonthlySallaryEmployee
    {
        public Secretary(string _name, int _age) : base(_name, _age, 20000) { }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.Write(" Pozice: sekretářka");
        }
    }
}
