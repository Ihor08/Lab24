using System;
namespace Lab24
{
    class Class1
    {
        static void Main()
        {
            const int n = 6;
            int[] a = new int[n] { 3, 12, 5, -9, 8, -4 };

            int x1 = 0;
            int x2 = 0;
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0 && x == 0)
                {
                    x1 = i;
                    x++;
                }
                if (a[i] < 0 && x == 1)
                {
                    x2 = i;
                }
            }
            int sum = 0;
            for (int i = x1 + 1; i < x2; i++)
            {
                sum = sum + a[i];



            }



            int min = a[0]; // мінімальний елемент
            for (int i = 0; i < n; i++)
                if (a[i] < min) min = a[i];
            Console.WriteLine("Мінімальний елемент = " + min);
            Console.WriteLine("Сума в межах від " + x1 + " до " + x2 + " = " + sum);
        }
    }
}
