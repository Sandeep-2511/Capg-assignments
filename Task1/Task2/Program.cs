using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {2,4,6,8,10,12,14,16,18,20,11};
            int[] array2 = new int[] {1,3,5,7,9,11,13,15,17,19 };

            var query1 = (from i in array1 select i).Union(from j in array2 select j);

            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------Intersect-------------");

            var query2 = (from i in array1 select i).Intersect(from j in array2 select j);

            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------Except-------------");

            var query3 = (from i in array1 select i).Except(from j in array2 select j);

            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------Concat-------------");

            var query4 = (from i in array1 select i).Concat(from j in array2 select j);

            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Aggregate Functions:-");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Sum:-");

            int sum1 = (from i in array1 select i).Sum();
            int sum2 = (from i in array2 select i).Sum();

            Console.WriteLine("Total Sum of two arrays:-" + (sum1 + sum2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Max:-");

            int max1 = (from i in array1 select i).Max();
            int max2 = (from i in array2 select i).Max();

            Console.WriteLine("Maximum number in both arrays:-" + (max1, max2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Min:-");

            int min1 = (from i in array1 select i).Min();
            int min2 = (from i in array2 select i).Min();

            Console.WriteLine("Minimum number in both arrays:-" + (min1, min2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Average:-");

            double avg1 = (from i in array1 select i).Average();
            double avg2 = (from i in array2 select i).Average();

            Console.WriteLine("Average of arrays:-" + (avg1, avg2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Count:-");

            int count1 = (from i in array1 select i).Count();
            int count2 = (from i in array2 select i).Count();

            Console.WriteLine("Total number of elements in two arrays:-" + (count1, count2));

            Console.WriteLine("-----------Distinct array1------------");

            var query19 = (from i in array1 select i).Distinct();
            foreach (int i in query19)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------Distinct array2------------");
            var query20 = (from i in array2 select i).Distinct();
            foreach (int i in query20)
            {
                Console.WriteLine(i);
            }
        }
    }
}
