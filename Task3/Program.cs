using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.WriteLine($"Число {numb} является четным");
            }
            else
            {
                Console.WriteLine($"Число {numb} является нечетным");
            }
            
        }
    }
}
