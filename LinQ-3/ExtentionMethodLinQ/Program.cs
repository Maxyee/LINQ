using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName = "mohon";
            //string result = strName.ChangeFirstLetterCase();

            //string result = StringHelper.ChangeFirstLetterCase(strName);

            //extention method it is.....
            string result = strName.ChangeFirstLetterCase();
            Console.WriteLine(result);


            List<int> Numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};

            //IEnumerable<int> EvenNumbers = Numbers.Where(n => n%2 == 0);
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);

            foreach (int evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
            Console.ReadKey();
        }
    }
}
