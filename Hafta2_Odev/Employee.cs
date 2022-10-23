using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Odev
{
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Employee> list = new List<Employee>();
        public Employee()
        {
            
        }
       public  Employee(int id,string fn,string ln)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
        }

        
        

        public void Add(Employee employee)
        {
            list.Add(employee);

            Console.WriteLine(Id +" Numarali Isci Eklendi...");
        }

        public void Remove(Employee employee , int a)
        {
            if(a==Id)
            {
                list.Remove(employee);
                Console.WriteLine(Id + " Numarali Isci Cikarildi...");
            }
            else
            {
                Console.WriteLine("Bu Id'e Sahip Bir Isci Bulunmamaktadır...");
            }
        }

       
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Id}";
        }

        
    }
}
