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
            int Full_Time = 1;
            Random random = new Random();

            int CheckAttendance = random.Next(2);

            int Wage_Per_Hour = 20, Full_Time_Hours = 8;


            int Employee_Wage;

            if (CheckAttendance == Full_Time)
            {
                Employee_Wage = Wage_Per_Hour * Full_Time_Hours;

                Console.WriteLine("Employee Wage is : " + Employee_Wage + " Rupees");
            }
            else
            {

                Console.WriteLine("The Employee is Absent");
            }

        }
    }
}
