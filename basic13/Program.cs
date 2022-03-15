using System;
using System.Collections.Generic;

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
            // GetAverage(myNumbers);
            // Console.WriteLine(OddArray());
            // Printer(OddArray());
            int[] tester = new int[] {2,-5,8,-8,6,9,10};
            // int[] squared = SquareArrayValues(tester);
            // Printer(squared);
            // Console.WriteLine(GreaterThanY(tester, 5));
            // int[] newArr = EliminateNegatives(tester);
            // MinMaxAvg(tester);
            // ShiftValues(tester);
            // Printer(tester);
            // Printer(newArr);
            object[] thisObjArr = NumToString(tester);
            Printer(thisObjArr);
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

        public static int[] OddArray()
        {
            int size = 255/2 + 1;
            int[] odds = new int[size];
            int count = 0;
            for(int x = 1; x <= 255; x+=2)
            {
                odds[count] = x;
                count++;
            }
            return(odds);
        }

// Changed printer to an object[] from an int[] to quickly print the last array.
        public static void Printer(object[] numArr)
        {
            for(int x = 0; x < numArr.Length; x++)
            {
                Console.WriteLine(numArr[x]);
            }
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for(int x = 0; x < numbers.Length; x++)
            {
                if(numbers[x] > y)
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] SquareArrayValues(int[] numbers)
        {
            for(int x = 0; x < numbers.Length; x++)
            {
                numbers[x] = numbers[x] * numbers[x];
            }
            return numbers;
        }

        public static int[] EliminateNegatives(int[] numbers)
        {
            for(int x = 0; x < numbers.Length; x++)
            {
                if(numbers[x] < 0)
                {
                    numbers[x] = 0;
                }
            }
            return numbers;
        }

        public static void MinMaxAvg(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int avg = 0;
            int sum = 0;
            for(int x = 0; x < numbers.Length; x++)
            {
                if(numbers[x] > max)
                {
                    max = numbers[x];
                }
                if(numbers[x] < min)
                {
                    min = numbers[x];
                }
                sum += numbers[x];
            }
            avg = sum/numbers.Length;
            Console.WriteLine($"Min is {min}, Max is {max}, Average is {avg}");
        }

        public static void ShiftValues(int[] numbers)
        {
            for(int x = 0; x < numbers.Length; x++)
            {
                if(x == numbers.Length - 1)
                {
                    numbers[x] = 0;
                }
                else 
                {
                    numbers[x] = numbers[x+1];
                }
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] myArr = new object[numbers.Length];
            for(int x = 0; x < numbers.Length; x++)
            {
                if(numbers[x] < 0 )
                {
                    myArr[x] = "Dojo";
                }
                else
                {
                    myArr[x] = numbers[x];
                }
            }
            return myArr;
        }

    }
}