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
            int Wage_Per_Hour = 20, Full_Time_Hours = 8, Part_Time_Hours = 4;
            int Number_of_Working_Days = 0;
            int Number_of_Working_Hours = 0;
            int max_Working_Hours = 100;
            int max_Working_Days = 20;
            int Employee_Wage_for_Month;
            Random random = new Random();


            while (Number_of_Working_Days < max_Working_Days && Number_of_Working_Hours < max_Working_Hours)
            {
                int Employee = random.Next(3);
                switch (Employee)
                {
                    case 1:

                        Console.WriteLine("Employee is Present for Full Time");

                        Number_of_Working_Hours += Full_Time_Hours;

                        break;

                    case 2:
                        Console.WriteLine("Employee is Present for Part Time");

                        Number_of_Working_Hours += Part_Time_Hours;

                        break;

                    default:

                        Console.WriteLine("Employee is Absent");

                        break;
                }

                Employee_Wage_for_Month = Number_of_Working_Hours * Wage_Per_Hour;

                Console.WriteLine("Employee Wage of Employees for a Month is : " + Employee_Wage_for_Month + " Rupees");
            }
        }
    }
}
