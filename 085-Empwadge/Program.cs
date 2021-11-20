using System;

namespace _085_Empwadge
{
    class Program
    {
       
        public static void Main()
        {
            int isfulltime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isfulltime)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();

        }
    }
}
