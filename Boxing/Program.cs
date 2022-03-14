using System;

namespace Boxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();

            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            foreach(object myItem in myList)
            {
                if(myItem is int)
                {
                    Console.WriteLine(myItem.ToString());
                }
                else if(myItem is string)
                {
                    Console.WriteLine(myItem);
                }
                else
                {
                    Console.WriteLine(myItem);
                }
            }
            int sum = 0;
            foreach(object item in myList)
            {
                if(item is int)
                {
                    sum += (int)item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}