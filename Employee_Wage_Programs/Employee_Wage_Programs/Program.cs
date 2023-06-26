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

            //***************Day-9 Assignments***************

            Console.WriteLine("Use_Case-6 for Calculating Wages of Employees for a Month Untill the Condition Satisfied");

            EmployeeWage_UseCases.Employee_Attendance();

            Console.ReadLine();
        }
    }
}
