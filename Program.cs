using System;


namespace Lab3._3
{
    public class Program

    {
        static public int Sum_el(int[] a, int n)
        {

            int MaxValue = a[0];        //знаходимо максимальне значення

            for (int i = 1; i < n; i++)
            {
                if (a[i] > MaxValue)
                {
                    MaxValue = a[i];
                }
            }
            return MaxValue;
        }
        static public int Dob_el(int[] a, int n) //добуток елементів масиву, розташованих між першим й  від’ємними елементами
        {
            int min = -999, max = -999, max_in = 999, min_in = 998, dob = 0;
            for (int i = n - 1; i >= 0; --i)
                if (a[i] > 0)
                    min = a[i];
            for (int i = n - 1; i >= 0; --i)
                if (a[i] > 0 && a[i] != min)
                    max = a[i];

            if (max == -999 && min != -999)            //пошук помилок
                dob = -999;
            else if (min == -999)                 //пошук помилок
                dob = 999;
            else
            {
                for (int i = 0; i < n; ++i)
                {
                    if (a[i] == min)
                        min_in = i;
                    if (a[i] == max)
                        max_in = i;
                }
                for (int i = min_in + 1; i < max_in; ++i)
                    dob += a[i];
            }
            return dob;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть довжину массива:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];            // створюємо масив
            Random rand1 = new Random();
            int sum = 0, dob = 1;

            for (int i = 0; i < n; ++i)
            {
                a[i] = rand1.Next(-100, 100);  //вводимо значення за допомогою рандомізатора
                Console.WriteLine(a[i]);
            }
            sum = Sum_el(a, n);
            dob = Dob_el(a, n);
            Console.WriteLine("\nмаксимальний елемент масиву:" + sum);
            if (dob == -999)
                Console.WriteLine("в массивi лише один додатній елемент");
            else if (dob == 999)
                Console.WriteLine("в массивi нема додатніх елементiв");
            else
                Console.WriteLine("суму елементів масиву, розташованих між першим й другим додатними елементами: " + dob);
        }

    }
}