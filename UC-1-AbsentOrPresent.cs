using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_day3
{
    public class UC_1_AbsentOrPresent
    {
        /// <summary>
        ///UC-1-Employees the present or absent.
        /// </summary>
        public static void EmployeePresentOrAbsent()
        {
            Random random = new Random();
            int num = random.Next(2);

            if (num == 1)
            {
                Console.WriteLine("Emplyoee is Present");
            }
            else
            {
                Console.WriteLine("Emplyoee is Absent");
            }
        }
    }
}
