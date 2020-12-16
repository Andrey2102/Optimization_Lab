//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Diagnostics;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            int[,] a = new int[100, 100];
            int res = 0;

            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    a[j, i] = a[j - 1, i - 1] + 1;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    a[j, i]++;
                }
            }

            watch.Stop();
            var first = watch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Task variant:  " + first);
            /////////////////////////////////////////////
            
            watch.Restart();
                
            int[,] a2 = new int[100, 100];

            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    a2[j, i] = a2[j - 1, i - 1] + 1;
                    a2[j, i]++;
                }
            }

            watch.Stop();
            var second = watch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Optimization:  " + second);
             /////////////////////////////////////////////
            
            watch.Restart();
                
            int[,] a3 = new int[100, 100];

            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    a3[i, j] = a3[j - 1, i - 1] + 1;
                    a3[i, j]++;
                }
            }

            watch.Stop();
            var third = watch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Optimization 2:  " + third);

        }
    }
}
