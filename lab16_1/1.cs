using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Введите размер массива: ");
            n = int.Parse(ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Write("A[{0}] = ", i);
                a[i] = int.Parse(ReadLine());
            }

            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (a[k] != a[i])
                {
                    k++;
                    a[k] = a[i];
                }
            }
            k++;
            for (int i = 0; i < k; i++)
            {
                Write(" {0} ", a[i]);
            }
        }
    }
}
