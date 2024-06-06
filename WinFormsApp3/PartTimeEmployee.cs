using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;





namespace EmployeeApplication
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }


        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.Department = dept;
            this.JobTitle = job;
            BasicSalary = 0.0;

        }

        public void computeSalary(int hoursWorked, double ratePerhour)
        {
            BasicSalary = ratePerhour * hoursWorked;
        }
        public double getSalary()
        {
            return BasicSalary;
        }


    }
}
