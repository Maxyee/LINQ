using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = {"Bangladesh", "UK", "US", "Finland", "Spain"};

            //string result = string.Empty;

            //foreach (string str in countries)
            //{
            //    result = result + str + ", ";
            //}

            //int lastIndex = result.LastIndexOf(",");
            //result = result.Remove(lastIndex);


            //now LinQ
            string result = countries.Aggregate((a, b) => a + ", " + b);
            Console.WriteLine(result);

            int[] Numbers = {2, 3, 4, 5};

            //foreach (int i in Numbers)
            //{
            //    result = result + i;
            //}

            //LinQ aggeregate function...
            int result2 = Numbers.Aggregate((a, b) => a*b);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
