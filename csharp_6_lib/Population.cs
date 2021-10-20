using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6_lib
{
    public class Population
    {
        public int personCount = 0;
        public Person[] persons = new Person[0];

        public void Add(Person a)
        {
            if (a != null)
            {
                Array.Resize(ref persons, persons.Length + 1);
                persons[personCount] = a;
                personCount++;
            }
        }

        public void PrintUnemployed()
        {
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is Unemployed)
                {
                    persons[i].PrintInfo();
                    Console.Write("\n");
                }
            }
        } 
        public void PrintEmployeesWithSallary()
        {
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is Employee)
                {
                    persons[i].PrintInfo();
                    Console.WriteLine(" Plat: " + (persons[i] as Employee).GetSalary());
                }
            }
        }
        public Employee GetPersonWithHighestSallary()
        {
            Employee tmp = null;
            double tmp_salary = 0;
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is Employee && (persons[i] as Employee).GetSalary() > tmp_salary)
                {
                    tmp = (persons[i] as Employee);
                    tmp_salary = tmp.GetSalary();
                }
            }
            return tmp;
        }
        public HourlySallaryEmployee[] GetHorlySallaryEmployees()
        {
            HourlySallaryEmployee[] tmp = new HourlySallaryEmployee[0];
            int index = 0;
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is HourlySallaryEmployee)
                {
                    Array.Resize(ref tmp, tmp.Length + 1);
                    tmp[index] = (persons[i] as HourlySallaryEmployee);
                    index++;
                }
            }
            return tmp;
        }
        public void IncreaseHorlySallary(HourlySallaryEmployee[] _hourlySallaryEmployees, double _hourlyAddSalary)
        {
            foreach (var item in _hourlySallaryEmployees)
            {
                item.HourlySallary += _hourlyAddSalary;
            }
        }
    }
}
