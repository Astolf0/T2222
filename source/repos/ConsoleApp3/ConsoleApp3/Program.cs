﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static double razdylitor(ref int a, ref int b)
        {
            double g = a / Convert.ToDouble(b);
            return g;
        }
        static int min(int a, int b)
        {
            int c = a - b;
            return (c);

        }
        static int max(int a, int b)
        {
            int c = a + b;
            return (c);

        }
        static int umno(ref int a, ref int b)
        {
            int g = a * b;
            return g;
        }
        static void Main(string[] args)
        {
        }
    }
}
