using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            int[] a = new int[50];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] > 0)
                {
                    n++;
                    for (int j = n - 1; j > i; j--)
                    {
                        a[j] = a[j - 1];
                    }
                    a[i] = 0;
                }
            }


            for (int i = 0; i < n; i++)
            {
                Write(a[i] + " ");
            }
        }
    }
}
