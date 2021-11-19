using System;

namespace _085_Empwadge
{
    class Program
    {
        private static int emphr;
        /// <summary>
        /// use of switch statement
        /// </summary>
        public static void Main()
        {
            int isfulltime = 1;
            int isparttime = 2;

            int empwadge = 0;
            int rateperHr = 20;
            int empHr = 0;

            Random random = new Random();
            int input = random.Next(0, 3);
            switch (input)
            {
                case 1:
                     emphr = 8;
                    Console.WriteLine("Employee is present for fulltime");
                    break;

                case 2:
                     emphr = 4;
                    Console.WriteLine("Employee is present for Parttime");
                    break;

                default:
                     emphr = 0;
                    Console.WriteLine(" employee is absent");
                    break;


                    
        }
            int empwage = empHr * rateperHr;
            Console.WriteLine("emp wadge per day is " + empwadge);
        }
    }
}
