using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create a string array with following names "Bob", "Mary", "Joe", "Sue", "John","Nancy"
            string[] names = new string[6] { "Bob", "Mary", "Joe", "Sue", "John", "Nancy" };

            //Print list of name to console log using for loops, while loops, foreach loop
            //foreach loop
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //for loop
            for (int i = 0; i < names.Length; i++)
            {
                //string name = names[i];
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            //while loop
            int c = 0;
            while (c < names.Length)
            {
                Console.WriteLine(names[c]);
                c++;
            }
            Console.ReadLine();

            //Create a list with following number 1, 3, 4 , 5, 6, 7, 8 , 13 , 15
            List<int> IntegerList = new List<int>();
            IntegerList.Add(1);
            IntegerList.Add(3);
            IntegerList.Add(4);
            IntegerList.Add(5);
            IntegerList.Add(6);
            IntegerList.Add(7);
            IntegerList.Add(8);
            IntegerList.Add(13);
            IntegerList.Add(15);

            //Print list of number to console log using for loops, while loops, foreach loop
            //foreach
            foreach (int integer in IntegerList)
            {
                Console.WriteLine(integer);
            }
            Console.ReadLine();

            //for loop
            for (int i = 0; i < IntegerList.Count; i++)
            {
                Console.WriteLine(IntegerList[i]);
            }
            Console.ReadLine();

            //while loop
            int d = 0;

            while (d < IntegerList.Count)
            {
                Console.WriteLine(IntegerList[d]);
                d++;
            }
            Console.ReadLine();

            //Print Sum of number of the number list
            int sum = 0;
            for (int i = 0; i < IntegerList.Count; i++)
            {
                sum = sum + IntegerList[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();

            //Print the number list of all number can't divide by 2
            //using foreach
            foreach (int integer in IntegerList)
            {
                if ((integer % 2) != 0)
                {
                    Console.WriteLine(integer);
                }
            }
            Console.ReadLine();

            //Print the max number of the number list
            int Max = IntegerList.Max();
            Console.WriteLine(Max);
            Console.ReadLine();

            //Print the min number of the number list
            int Min = IntegerList.Min();
            Console.WriteLine(Min);
            Console.ReadLine();

            //Print the average of the list
            double Avg = IntegerList.Average();
            Console.WriteLine(Avg);
            Console.ReadLine();

            //Print the number list order by descending
            IntegerList.Sort();
            IntegerList.Reverse();

            foreach (int integer in IntegerList)
            {
                Console.WriteLine(integer);
            }
            Console.ReadLine();


            //Using While loop to generate the list integer number less than 100 and print it out
            IntegerList.Reverse();
            int e = 0;

            while (e < IntegerList.Count)
            {
                if (IntegerList[e] <= 4)
                {
                    Console.WriteLine(IntegerList[e]);
                }
                e++;
            }
            Console.ReadLine();
        }
    }
}
