using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageWithClassMthods
{
    
    class EmpWage
    {
        int isPresent = 1;
        
        
        public void Attenedance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
            {
                Console.WriteLine("employee is absent");
            }
            else
            {
                Console.WriteLine("employee is present");

            }
        }
    }
}
