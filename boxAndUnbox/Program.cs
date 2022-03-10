using System;

namespace boxAndUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");
            int sum = 0;
            for (var idx = 0; idx < myList.Count; idx++)
            {
                if(myList[idx] is string)
                {
                    Console.WriteLine(myList[idx] + " is a string");
                } 
                else if(myList[idx] is bool)
                {
                    Console.WriteLine(myList[idx] + " is a boolean");
                }
                else if(myList[idx] is int)
                {
                    sum += (int)myList[idx];
                }
                else{
                    Console.WriteLine("Something has gone awry!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}