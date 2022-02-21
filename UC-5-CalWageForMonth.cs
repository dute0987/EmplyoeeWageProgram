using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_day3
{
    public class UC_5_CalWageForMonth
    {
        public static void WageCalculationForMonth()
        {
            const int IsPartTime = 1;
            const int FullTime = 2;
            int WageRatePerHour = 20;
            int EmpWage = 0;
            int EmpHour = 0;
            int TotalSalary = 0;
            int NumberOfWorkingDay = 20;

            for ( int i = 1;i <= NumberOfWorkingDay; i++)
            {
                Random random = new Random();
                int num = random.Next(3);

                if (num == IsPartTime)
                {
                    EmpHour = 8;
                }
                else if (num == FullTime)
                {
                    EmpHour = 12;
                }
                else
                {
                    EmpHour = 0;
                }
                EmpWage = (WageRatePerHour * EmpHour);
                TotalSalary = (TotalSalary + EmpWage);
                Console.WriteLine("The Total salary for the month is :- " + TotalSalary);
            }
        }
    }
}
