using System;

namespace _085_Empwadge
{
    class Program
    {
        static void Main()
        {
            int ispresent = 1;
            int empwadge = 0;
            int rateperHr = 20;
            int empHr = 0;
            
            Random random = new Random();
            int input = random.Next(0,2);
            if (input == ispresent)
            {
                int emphr = 8;
                Console.WriteLine("Employee is present");
               
            }
            else
            {
                int emphr = 0;
                Console.WriteLine(" employee is absent");
            }
            int empwage = empHr * rateperHr;
            Console.WriteLine("emp wadge per day is " + empwadge);
        }
    }
}
