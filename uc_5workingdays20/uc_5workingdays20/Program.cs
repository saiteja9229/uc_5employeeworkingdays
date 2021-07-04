using System;

namespace uc_5workingdays20
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 2;

        public static int EMP_RATE_PER_HOUR { get; private set; }

        static void Main(string[] args)
        {
            //variables
            int emphrs = 0, empwage = 0, totalempwage = 0;
            //computation
            for(int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
                totalempwage += empwage;
                Console.WriteLine("emp wage : " + empwage);
            }
            Console.WriteLine("total emp wage : " + totalempwage);
        }
    }
}
