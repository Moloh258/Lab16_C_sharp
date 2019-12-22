using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab16_3
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

            int min = a[0], max = a[0], minind = 0, maxind = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                        minind = i;
                    }
                    if (a[i] > max)
                    {
                        max = a[i];
                        maxind = i;
                    }
                }
            }

            if (maxind > minind) maxind++;
            if (minind == 0)
            {
                Write(" 0 ");

            }
            if (minind != 0)
            {
                n++;
                for (int i = n - 1; i >= minind; --i)
                    a[i] = a[i - 1];

                a[minind] = 0;
            }

            n++;
            for (int i = n - 1; i > maxind + 1; --i)
                a[i] = a[i - 1];

            a[maxind + 1] = 0;

            for (int i = 0; i < n; i++)
            {
                Write(a[i] + " ");
            }
        }
    }
}
