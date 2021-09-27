using System;
using System.Collections.Generic;
using System.Text;

namespace EmpPartTimeUC3
{
    class EmpWage
    {
        //constant
        const  int empFullTime = 1;
        const int empPartTime = 2;
        const int empWagePerHour = 20;

        

        public static int EmployeeWageAlongPartTime()
        {
            //variable
            int empWage = 0;
            int empHr = 0;
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
          
            Console.WriteLine("Emploayee wage of a day is : " + empWage);
            return empWage;
        }
    }
}
