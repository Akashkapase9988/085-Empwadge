using System;

namespace _085_Empwadge
{
    class Program
    {
        static void Main()
        {
            //attendence
            int ispresent = 1;
            
            Random random = new Random();
            int input = random.Next(0,2);
            if (input == ispresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine(" employee is absent");
            }
        }
    }
}
