using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //how to find minimum number using Linq
            int result = Numbers.Min();
            Console.WriteLine(result);

            //find largest number using linq
            int result2 = Numbers.Max();
            Console.WriteLine(result2);

            //find the sum of all number using Linq
            int result3 = Numbers.Sum();
            Console.WriteLine(result3);

            //find the minimum even number from array using linq
            int result4 = Numbers.Where(x => x%2 == 0).Min();
            Console.WriteLine(result4);

            //find the maximum odd number using linq
            int result5 = Numbers.Where(x => x%2 == 1).Max();
            Console.WriteLine(result5);

            //sum of all even numbers
            int result6 = Numbers.Where(x => x%2 == 0).Sum();
            Console.WriteLine(result6);

            //find the total element in array using linq function
            int result7 = Numbers.Count();
            Console.WriteLine(result7);

            //find even element in array ..
            int result8 = Numbers.Where(x => x%2 == 0).Count();
            Console.WriteLine(result8);

            //find average value of the array using Linq
            double result9 = Numbers.Average();
            Console.WriteLine(result9);

            //find the average of even numbers using linq
            double result10 = Numbers.Where(x => x%2 == 0).Average();
            Console.WriteLine();

            //string maximum latter courntry name find out using linq 
            string[] countries = {"Bangladesh", "India", "Finland"};

            int maxLetterCount = countries.Max(x => x.Length);
            int minLetterCount = countries.Min(x => x.Length);

            Console.WriteLine("The shortest country name has {0} characters in its name",minLetterCount);
            Console.WriteLine("The shortest country name has {0} characters in its name", maxLetterCount);

            Console.ReadKey();
        }
    }
}
