using System;

namespace Lab_2._1
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.WriteLine("Введiть порядковий номер студента :" );
            a = int.Parse(Console.ReadLine());
            switch (a) 
            {
                case 1:
                    Console.WriteLine("Бензар Олександер");
                    break;
                case 2:
                    Console.WriteLine("Беркоша Микола");
                    break;
                case 3:
                    Console.WriteLine("Бинда Роман");
                    break;
                case 4:
                    Console.WriteLine("Борлодян Віталiй");
                    break;
                case 5:
                    Console.WriteLine("Василик Микола");
                    break;
                case 6:
                    Console.WriteLine("Велущак Iгор");
                    break;
                case 7:
                    Console.WriteLine("Гакман Олексiй");
                    break;
                case 8:
                    Console.WriteLine("Герман Андрiй ");
                    break;
                case 9:
                    Console.WriteLine("Горенко Iван");
                    break;
                case 10:
                    Console.WriteLine("Iванiн Олександр");
                    break;
                default: Console.WriteLine("Такого студента немає\n"); break;

            }
        }

    }
}
