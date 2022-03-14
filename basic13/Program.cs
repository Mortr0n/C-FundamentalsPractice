using System;

namespace Basic13
{
    public class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int[] myNumbers = new int[]{4,5,68, 76, -3, -9, 900, 54};
            // LoopArray(myNumbers);
            // FindMax(myNumbers);
            GetAverage(myNumbers);
        }

        public static void PrintNumbers()
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine($"i is {i}");
            }
        }

        public static void PrintOdds()
        {
            for(int i = 1; i <= 255; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine($"i is {i}");
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"i is {i} sum is {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for(int myInt = 0; myInt < numbers.Length; myInt++)
            {
                Console.WriteLine($"Number is {numbers[myInt].ToString()}");
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for(int x = 0; x < numbers.Length; x++)
            {
                if(max < numbers[x])
                {
                    max = numbers[x];
                }
            }
            Console.WriteLine(max);
            return(max);
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            int avg = 0;
            for(int x = 0; x < numbers.Length; x++)
            {
                sum += numbers[x];
            }
            avg = sum/numbers.Length;
            Console.WriteLine(avg);
        }
    }
}