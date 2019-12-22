using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t = 0, k = 0;

            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        k++;
                        t = j;
                    }
                }
                if (k == 2)
                {
                    for (int j = t; j < n - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    n--;
                    for (int j = i; j < n - 1; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    n--;
                    i--;
                }
                k = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Write(" {0} ", a[i]);
            }
        }
    }
}
