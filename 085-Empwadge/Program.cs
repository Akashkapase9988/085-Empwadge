using System;

namespace _085_Empwadge
{
    class Program
    {
        static void Main()
        {
            int isfulltime = 1;
            int isparttime = 2;
            int ispresent = 1;
            int empwadge = 0;
            int rateperHr = 20;
            int empHr = 0;
            
            Random random = new Random();
            int input = random.Next(0,3);
            if (input == isfulltime)
            {
                int emphr = 8;
                Console.WriteLine("Employee is present for fulltime");

            }
            else if (input == isparttime)
            {
                empHr = 4;
                Console.WriteLine("Employee is present for Parttime");
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
