using System;

namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите числа a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число c");
                double c = double.Parse(Console.ReadLine());
                double part1 = (1.5 * Math.Pow(a - b, 2)) / (Math.Abs(a - b) * c);
                double part2 = Math.Sqrt(Math.Abs(a - b)) * Math.Pow(10, 3);
                double part3 = 2.5 * (a * a + 2.75) * Math.Sin(-2 * a) / (3 + a * a * b * c);
                int res = (int)part1 + (int)part2 - (int)part3;
                Console.WriteLine($"Результат:\t{res}");
            }
        }
    }
}