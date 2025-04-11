using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
       public void GetEmployeeInfo()
        {
            Console.WriteLine("Enter the Employee Id");
            Id= Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
        }
    }
}

