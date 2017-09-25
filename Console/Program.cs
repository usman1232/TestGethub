using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            string C_Case;
            Console.WriteLine("Please enter an interger");
            C_Case = Console.ReadLine();
            Console.WriteLine("Result = " + BreakCamelCase(C_Case));
            var res = Regex.Replace("FirstName", "([A-Z])", " $1").Trim();
            Console.ReadKey();
        }
        public static string ReverceString(string CamelCase)
        {
            char[] numbers = CamelCase.ToCharArray();
            String result = "";
            foreach (var chr in CamelCase)
            {
                result = chr + result;
            }
            return result;
        }
        public static string BreakCamelCase(string CamelCase)
        {
            char[] numbers = CamelCase.ToCharArray();
            String result = "";
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] > 60 && numbers[i] < 91)
                {
                    result = result + " " + numbers[i];
                }
                else
                {
                    result = result + chr;
                }
            }
            return result;
        }
    }
}
