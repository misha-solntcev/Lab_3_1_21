using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*21. Введите два числа(например, А= 45 и В = 8) и найдите частное 
    от деления нацело (в переменной k) и остаток от деления нацело, 
    используя только операцию вычитания.*/

namespace Lab_3_1_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 37;
            int B = 6;
            int ostatok = A;
            int integer = 0;
            while (ostatok > B)
            {
                ostatok -= B;
                integer++;
            }
            Console.WriteLine(integer);
            Console.WriteLine(ostatok);
            Console.ReadKey();
        }
    }
}
