using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Employee Wage Computation Program ****");

            //**************************Day - 10 Assignments**************************

            Console.WriteLine("Use_Case-12 for Ability to save total Employee Wages for Multiple Companies in ArrayList Using Interface Approach ");
                                    
            IEmpWageCalculator empWageCalculator = new EmployeeWageBuilder();
            empWageCalculator.AddCompany("Suzuki", 1100, 30, 240);
            empWageCalculator.AddCompany("Tata", 1500, 31, 230);
            empWageCalculator.AddCompany("Hyundai", 1105, 29, 215);
            empWageCalculator.AddCompany("Mahindra", 1035, 28, 235);
            empWageCalculator.Employee_Attendance();
            
            Console.ReadLine();
        }
    }
}
