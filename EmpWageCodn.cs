using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageofMonthClassMethod
{
    class EmpWageCodn
    {
        const int empFullTime = 1;
        const int empPartTime = 0;
        const int empRatePerHour = 20;
        const int maxWorkingHours = 100;
        const int maxWorkingDays = 20;

        public static int EmployeeWageAlongPartTimeSwitch()
        {
            //variable
            int empWage = 0;
            int totalEmpHrs = 0;
            int totalEmpSal = 0;
            int empHr = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxWorkingHours && totalWorkingDays < maxWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHr;
                empWage = empHr * empRatePerHour;
                Console.WriteLine("Days#:" + totalWorkingDays + " Employee Hrs : "
                    + empHr + " Employee wage of day " + empWage);

            }
            totalEmpSal = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total employee salary of a month : " + totalEmpSal);
            return totalEmpSal;
        }
    

    }

}