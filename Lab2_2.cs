using System;

namespace Lab_2._2

{
    class Program
    {
        static void Main()
        {
            double y, x = 1, b = 6, dx = 0.2;
            Console.WriteLine("X\t\tY");
            while (x <= b)
            {
                if (x < 0.2) //пошук помилок
                {
                    Console.WriteLine(Math.Round(x, 2) + "\tЛагарифм з відємного числа");
                }
                else
                {
                    y = Math.Log10(x);
                    Console.WriteLine(Math.Round(x, 2) + "\t\t" + Math.Round(x, 2));
                }
                x += dx;

            }
        }
    }
}

            

                
