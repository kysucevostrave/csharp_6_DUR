using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    public class Worker : HourlySallaryEmployee
    {
        public Worker(string _name, int _age) : base(_name, _age, 130) { }

        override public double GetBonus()
        {
            if (this.HoursWorked > 160)
            {
                return 5000;
            }
            return 0;
        }
    }
}
