using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_day3
{
    public class UC_2_CalculationOfDailyWage
    {
        /// <summary>
        /// UC-2-Cals the emp wage.
        /// </summary>
        public static void CalEmpWage()
        {
            int WageRatePerHour = 20;
            int FullDayHour = 8;
            int CalEmpWage = 0;

            Random random = new Random();
            int num = random.Next(2);

            if (num == 1)
            {
                CalEmpWage = WageRatePerHour * FullDayHour;

                Console.WriteLine("Wage Calculation is:- " + CalEmpWage);
            }
            else
            {
                CalEmpWage = 0;
                Console.WriteLine("Wage Calculation is:- " + CalEmpWage);
            }
        }
    }
}
