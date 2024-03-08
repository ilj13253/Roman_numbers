using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static string ConvertR(int n)
        {
            if (n < 1 || n < 3999)
            {
            }
            List<string> M = new List<string>() { " ", "M", "MM", "MMM" };//тут мы делаем тыс
            List<string> c = new List<string>() { " ", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };//тут мы делаем сот
            List<string> x = new List<string>() { " ", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };//тут мы делаем дяс
            List<string> e = new List<string>() { " ", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };//тут мы делаем ед
            string roman = M[n / 1000] + c[(n % 1000) / 100] + x[(n % 100) / 10] + e[n % 10];//тут мы делаем логику как должны быть римские число
            return roman;
        }
        static void Main(string[] args)
        {
            try//сделал исключения чтобы если написал 4к то будет выводиться фраза:)
            {
                int g = 3;
                //g= int.Parse(Console.ReadLine()); можно тут раскомментить при желании 
                string roman = ConvertR(g);
                Console.WriteLine($"{g}:is represtend as {roman} ones");
            }
            catch(Exception)
            {
                Console.WriteLine("ТЫ ХТО?");
            }
            Console.ReadKey();
        }
    }
}
