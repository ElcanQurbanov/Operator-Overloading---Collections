using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Collection_practices.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public static bool operator > (Employee emp1, Employee emp2)
        {
            return emp1.Age> emp2.Age;
        }


        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Age < emp2.Age;
        }
    }
}
