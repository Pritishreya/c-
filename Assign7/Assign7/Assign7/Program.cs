using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hr = new HR();
            Employee developer = new Developer();
            hr.Salary_Cal(8000, 4);
            developer.Salary_Cal(8000, 5);
        }
    }
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public double Annual_salary { get; set; }
        public int joining_date { get; set; }
        public abstract void Salary_Cal(double Annual_salary, int Experience);
    }
    public class HR : Employee
    {
        double total_salary = 0;
        public override void Salary_Cal(double Annual_salary, int Experience)
        {
            total_salary += (Annual_salary + (1000 * Experience));
            Console.WriteLine("The Salary of HR is " + " " + total_salary);
        }
    }
    public class Developer : Employee
    {
        double total_salary = 0;
        public override void Salary_Cal(double Annual_salary, int Experience)
        {
            total_salary += (Annual_salary + (2000 * Experience));
            Console.WriteLine("The Salary of Developer is " + " " + total_salary);
        }
    }
}
