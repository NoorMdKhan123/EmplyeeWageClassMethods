using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSwitchCaseClassMethod
{
    class EmpWageSwitch
    {
        const int empFullTime = 1;
        const int empPartTime = 0;
        const int empWagePerHour = 20;

        public static int EmployeeWageAlongPartTimeSwitch()
        {
            //variable
            int empWage = 0;
            int empHr = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case empFullTime:
                    empHr = 8;
                    break;

                case empPartTime:
                    empHr = 4;
                    break;

                default:
                    empHr = 0;
                    break;

            }

            empWage = empHr * empWagePerHour;
            Console.WriteLine("Emploayee wage of a day is " + empWage);
            return empWage;

        }
    }
}
