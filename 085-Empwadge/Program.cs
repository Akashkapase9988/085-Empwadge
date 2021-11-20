using System;

namespace _085_Empwadge
{
    
    class progarm
    {

        public const int isfulltime = 1;
        public const int isparttime = 2;
        public const int rateperhr = 20;
        public const int daysinmoth = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void main()
        {
            //
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {

                    case isfulltime:
                        empHrs = 4;
                        break;
                    case isparttime:

                        empHrs = 4;
                        break;
 
                   
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }

            int totalEmpWage = totalEmpHrs * rateperhr;
           

            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
