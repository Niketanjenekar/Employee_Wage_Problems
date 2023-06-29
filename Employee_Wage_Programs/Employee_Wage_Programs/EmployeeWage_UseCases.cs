using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Programs
{
    public class EmployeeWageBuilder
    {
        private string companyName;
        private int wage_Per_Hour;
        private int total_Working_Days;
        private int total_Working_Hours;
        
        public EmployeeWageBuilder(string companyName, int wage_Per_Hour, int total_Working_Days, int total_Working_Hours)
        {
            this.companyName = companyName;
            this.wage_Per_Hour = wage_Per_Hour;
            this.total_Working_Days = total_Working_Days;
            this.total_Working_Hours = total_Working_Hours;           

        }

        public void Employee_Attendance()
        {
            int number_of_Working_Days = 0;
            int number_of_Working_Hours = 0;
            int Full_Time_Hours = 8, Part_Time_Hours = 4;
            int employee_Wage_for_Month = 0;

            Console.WriteLine();
            Console.WriteLine("This is the Employee Wage Calculation For "+ companyName +" is :");
            Console.WriteLine();

            Random random = new Random();
            while (number_of_Working_Days <= total_Working_Days &&
                number_of_Working_Hours <= total_Working_Hours)
            {
                int Employee = random.Next(3);
                switch (Employee)
                {
                    case 1:

                        Console.WriteLine("Employee is Present for Full Time");
                        number_of_Working_Hours += Full_Time_Hours;
                        break;

                    case 2:
                        Console.WriteLine("Employee is Present for Part Time");
                        number_of_Working_Days += Part_Time_Hours;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                employee_Wage_for_Month = number_of_Working_Hours * wage_Per_Hour;
                Console.WriteLine("Calculated Wage for Employee is : " + employee_Wage_for_Month);
            }
            Console.WriteLine("Employee Wage of Employees of  "+ companyName +" for a Month is : "+
                                     employee_Wage_for_Month +" Rupees");
            Console.WriteLine("Employee Wage per Hour is : "+ wage_Per_Hour);
            Console.WriteLine("Employee Total Working Days are "+ total_Working_Days);
            Console.WriteLine("Employee Total Working Hours are "+ total_Working_Hours);
            
            Console.WriteLine("************************************************************************");
        }
    }
    
}
