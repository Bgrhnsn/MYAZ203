using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Odev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Bugra",
                LastName = "Sen",
                Id = 221118075
            };
            employee.Add(employee);

            Employee employee2 = new Employee
            {
                FirstName = "Kerem",
                LastName = "Dag",
                Id = 223232512
            };
            employee2.Add(employee2);

            employee.Remove(employee, 221118075);
           

            
            Console.ReadLine();

        }
    }
}
