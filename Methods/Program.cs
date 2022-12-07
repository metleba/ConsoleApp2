using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 8, 9 };
            int[] b = new int[] { 6, 8, 9 };
            int[] c = new int[] { 10, 3, 1 };

            a = c;
            c[1] = 15;
            Console.WriteLine(a[1]);

        }
    }
}
