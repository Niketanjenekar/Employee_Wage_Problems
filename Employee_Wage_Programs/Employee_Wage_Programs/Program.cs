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

            Console.WriteLine("Use_Case-9 for Ability to save total Employee Wages for Multiple Companies");
                                    
            EmployeeWageBuilder suzuki = new EmployeeWageBuilder("Suzuki", 1100, 30, 240);
            suzuki.Employee_Attendance();

            EmployeeWageBuilder tata = new EmployeeWageBuilder("Tata", 1500, 31, 230);
            tata.Employee_Attendance();
            
            EmployeeWageBuilder hyundai = new EmployeeWageBuilder("Hyundai", 1105, 29, 215);
            hyundai.Employee_Attendance();
            
            EmployeeWageBuilder mahindra = new EmployeeWageBuilder("Mahindra", 1035, 28, 235);
            mahindra.Employee_Attendance();


            Console.ReadLine();
        }
    }
}
