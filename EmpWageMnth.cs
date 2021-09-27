using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageMonth
{
    class EmpWageMnth
    {

        //constant
        const int empFullTime = 1;
        const int empPartTime = 2;
        const int empWagePerHour = 20;
        const int empWorkingDays = 20;



        public static int EmployeeWageAlongPartTime()
        {
            //variable
            int empWage = 0;
            int empHr = 0;
            int empSalMnth = 0;
            for (int days = 1; days <= empWorkingDays; days++)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 3);

                if (empCheck == empFullTime)
                {
                    empHr = 15;
                }
                else if (empCheck == empPartTime)
                {
                    empHr = 8;
                }
                else
                {
                    empWage = 0;
                }
                empWage = empHr * empWagePerHour;
                Console.WriteLine("Emploayee wage of a day "+days+ " is : "+ empWage);
            }
            empSalMnth = empWage * empWorkingDays;
            Console.WriteLine("Emploayee wage of a Month is : " + empSalMnth);

            return empWage;
        }
    }
}
    

