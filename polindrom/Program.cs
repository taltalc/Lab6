using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string resultstr = str.ToLower();
            resultstr = resultstr.Replace(" ", string.Empty);
            string resultstr1 = "";
            for (int i = resultstr.Length - 1; i >= 0; --i)

            {
                resultstr1 += (resultstr[i]);
            }
            if (resultstr1 == resultstr)
            {
                Console.WriteLine("Предложение-полиндром");
            }
            else
                Console.WriteLine("Предложение - не полиндром");



            Console.ReadKey();

        }
    }
}
