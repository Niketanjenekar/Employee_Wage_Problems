using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Programs
{
    interface IEmpWageCalculator
    {
        void AddCompany(string companyName, int wage_Per_Hour, int total_Working_Days, int total_Working_Hours);
        void Employee_Attendance();
    }
    public class CompanyEmployeeWage
    {
        public string companyName { get; set; }
        public int wage_Per_Hour { get; set; }
        public int total_Working_Days { get; set; }
        public int total_Working_Hours { get; set; }

        public int totalEmpWage { get; set; }

        public CompanyEmployeeWage(string companyname, int wageper_Hour, int total_working_Days, int total_working_Hours)
        {
            companyName = companyname;
            wage_Per_Hour = wageper_Hour;
            total_Working_Days = total_working_Days;
            total_Working_Hours = total_working_Hours;
            totalEmpWage = 0;
        }

    }
    public class EmployeeWageBuilder : IEmpWageCalculator
    {

        private ArrayList companyEmployeeWage;
        
        public EmployeeWageBuilder()
        {
            companyEmployeeWage = new ArrayList(5);
           
        }
        public void AddCompany(string companyname, int wageper_Hour, int total_working_Days, int total_working_Hours)
        {
           
            
            CompanyEmployeeWage companyemployeeWage = new CompanyEmployeeWage(companyname, wageper_Hour, total_working_Days, total_working_Hours);
            companyEmployeeWage.Add(companyemployeeWage);
            
        }

        public void Employee_Attendance()
        {
            foreach(CompanyEmployeeWage companyEmployeeWage in companyEmployeeWage)
            {
                int number_of_Working_Days = 0;
                int number_of_Working_Hours = 0;
                int Full_Time_Hours = 8;
                int Part_Time_Hours = 4;

                Random random = new Random();
                while (number_of_Working_Days <= companyEmployeeWage.total_Working_Days &&
                    number_of_Working_Hours <= companyEmployeeWage.total_Working_Hours)
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
                            number_of_Working_Hours += Part_Time_Hours;
                            break;

                        default:
                            Console.WriteLine("Employee is Absent");
                            break;
                    }
                    companyEmployeeWage.totalEmpWage = number_of_Working_Hours * companyEmployeeWage.wage_Per_Hour;
                    Console.WriteLine("Calculated Wage for Employee is : " + companyEmployeeWage.totalEmpWage);
                }
                Console.WriteLine("Employee Wage of Employees of  " + companyEmployeeWage.companyName + " for a Month is : " +
                                     companyEmployeeWage.totalEmpWage + " Rupees");

                Console.WriteLine("Employee Wage per Hour is : " + companyEmployeeWage.wage_Per_Hour);
                Console.WriteLine("Employee Total Working Days are " + companyEmployeeWage.total_Working_Days);
                Console.WriteLine("Employee Total Working Hours are " + companyEmployeeWage.total_Working_Hours);

                Console.WriteLine("************************************************************************");
            }
            
            
            
        }
    }
    
}
