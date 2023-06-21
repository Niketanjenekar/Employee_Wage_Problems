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

            //***************Day-3 Assignments***************

            Console.WriteLine("Use_Case-1 for checking Employee is Present or Absent");

            EmployeeWage_UseCases.Employee_Attendance();

            Console.ReadLine();
        }
    }
}
