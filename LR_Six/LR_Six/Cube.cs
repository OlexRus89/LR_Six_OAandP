using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Six
{
    class Cube
    {
        /* Класс «Куб». Реализовать ввод и вывод полей данных, вычисление
         * объема, площади поверхности, а также вывод информации об объекте.
         */
        private double a;

        public double GetV()
        {
            return (Math.Pow(a, 3));
        }

        public double GetS()
        {
            return (6 * Math.Pow(a, 2));
        }

        public void Info ()
        {
#if DEBUG
            Console.WriteLine();
#endif
            String str =
                "***************\n" +
                "*             *\n" +
                "*             *\n" +
                "*     Куб     *\n" +
                "*             *\n" +
                "*             *\n" +
                "***************\n";
            Console.WriteLine(str);
            Console.WriteLine("Результаты следующие:");
            Console.WriteLine(string.Format("V = {0:0.000}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.000}", GetS()));
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
        }
    }
}
