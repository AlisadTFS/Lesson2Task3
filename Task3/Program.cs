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
            string namemarket = "Зебра";
            string addresmarket = "г. Воронеж, ул. Бульвара Победы, д. 256";
            long inn = 7721511903;
            DateTime datetimesale = DateTime.Now;
            int codeproduct = 1158;
            string nameproduct = "Мясо птицы";
            float quantityproduct = 1.40f;
            float priceproduct = 250;
            float sumprice = quantityproduct * priceproduct;
            Console.WriteLine($"{namemarket, 40}");
            Console.WriteLine($"{addresmarket, 60}");
            Console.WriteLine($"{inn,45}");
            Console.WriteLine($"             Дата продажи: {datetimesale.ToString("d")} время продажи: {datetimesale.ToString("t")}");
            Console.WriteLine("Код продукта      Найменование       Кол-во         Цена        Сумма");
            Console.WriteLine($"{codeproduct} {nameproduct, 25} {quantityproduct.ToString("f2"), 10} кг. {priceproduct.ToString("f2"), 11}р. {sumprice.ToString("f2"), 9}р.");

        }
    }
}
