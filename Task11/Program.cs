using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    struct LineEqua
    {
        private double first;
        private double second;
        private double x;

        public void Read(double b, double k)
        {
            first = b;
            second = k;
            Root();
        }
        public void Root()
        {
            if (second != 0)
            {
                x = -first / second;
                Console.WriteLine("Значение х : {0}", x);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка! Деление на 0!");
                Console.ReadKey();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LineEqua rez = new LineEqua();
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            rez.Read(b, k);
        }
    }
}