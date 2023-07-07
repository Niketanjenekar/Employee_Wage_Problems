using Employee_Wage_Programs;
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

            Console.WriteLine("Use_Case-14 for Ability to get Total Employee Wages when Queried by Company Name");
                                    
            IEmpWageCalculator empWageCalculator = new EmployeeWageBuilder();

            Console.WriteLine("Please Choose the Correct Option from the list : ");
            Console.WriteLine("1. SUZUKI");
            Console.WriteLine("2. TATA");
            Console.WriteLine("3. HYUNDAI");
            Console.WriteLine("4. MAHINDRA");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("The Employee Wage for Suzuki is : ");
                    empWageCalculator.AddCompany("Suzuki", 1100, 30, 240);
                    empWageCalculator.Employee_Attendance();
                    break;
                case 2:
                    Console.WriteLine("The Employee Wage for Tata is : ");
                    empWageCalculator.AddCompany("Tata", 1500, 31, 230);
                    empWageCalculator.Employee_Attendance();
                    break;
                case 3:
                    Console.WriteLine("The Employee Wage for Hyundai is : ");
                    empWageCalculator.AddCompany("Hyundai", 1105, 29, 215);
                    empWageCalculator.Employee_Attendance();
                    break;
                case 4:
                    Console.WriteLine("The Employee Wage for Mahindra is : ");
                    empWageCalculator.AddCompany("Mahindra", 1035, 28, 235);
                    empWageCalculator.Employee_Attendance();
                    break;
                default:
                    Console.WriteLine("Please Enter the Correct Option From the List ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
