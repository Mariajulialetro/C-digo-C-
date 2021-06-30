﻿using System;
using System.Globalization;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, km;

            x = int.Parse(Console.ReadLine());

            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            km = (double) x / y;

            Console.WriteLine(km.ToString("F3", CultureInfo.InvariantCulture) + " km/l");



        }
    }
}
