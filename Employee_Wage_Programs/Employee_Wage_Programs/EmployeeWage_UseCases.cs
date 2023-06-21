using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Programs
{
    public class EmployeeWage_UseCases
    {
        public static void Employee_Attendance()
        {
            int Full_Time = 1, Part_Time = 2;

            int Wage_Per_Hour = 20, Full_Time_Hours = 8, Part_Time_Hours = 4;

            Random random = new Random();

            int CheckAttendence = random.Next(3);

            int Employee_Wage;

            if (CheckAttendence == Full_Time)
            {
                Console.WriteLine("Employee is Present for Full Time");

                Employee_Wage = Wage_Per_Hour * Full_Time_Hours;

                Console.WriteLine("Employee Wage of Full_Time Employees for a Month is : " + Employee_Wage + " Rupees");
            }
            else if (CheckAttendence == Part_Time)
            {
                Console.WriteLine("Employee is Present for Part Time");

                Employee_Wage = Wage_Per_Hour * Part_Time_Hours;

                Console.WriteLine("Employee Wage of Part_Time Employees for a Month is : " + Employee_Wage + " Rupees");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
