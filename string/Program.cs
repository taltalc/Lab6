using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strings = str.Split();
            string count = "";
            string searchString = "0";
            foreach (string s in strings)
            {
                count += s.Length;
                if (s.Length > searchString.Length)
                {
                    searchString = s;
                }



            }


            Console.WriteLine("Самое длинное слово в строке {0}", searchString);
            Console.ReadKey();


        }

    }
}
