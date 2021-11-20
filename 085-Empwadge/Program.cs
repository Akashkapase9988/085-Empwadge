using System;

namespace _085_Empwadge
{
    class Program
    {
        
        /// <summary>
        /// use of switch statement
        /// </summary>
        public static void Main()
        {
            int isfulltime = 1;
            int isparttime = 2;
            int dayinmonth = 20;
            int empwadge = 0;
            int rateperHr = 20;

            int empHr = 0;
            Random random = new Random();
            int input = random.Next(0, 3);
            switch (input)
            {
                case 1:
                     empHr = 8;
                    Console.WriteLine("Employee is present for fulltime");
                    break;

                case 2:
                     empHr = 4;
                    Console.WriteLine("Employee is present for Parttime");
                    break;

                default:
                     empHr = 0;
                    Console.WriteLine(" employee is absent");
                    break;


                    
        }
            int empwageperday = empHr * rateperHr;
            int empwagepermonth = empwageperday * dayinmonth;
            Console.WriteLine("emp wadge per day is " + empwagepermonth);
        }
    }
}
