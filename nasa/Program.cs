﻿using System;
using System.Collections.Generic;
using System.IO;

namespace nasa
{
    class Program
    {
        static void Main(string[] args)
        {
            var keresett = new List<Keres>();

            using var sr = new StreamReader(@"..\..\..\src\NASAlog.txt");
            while (!sr.EndOfStream)
            {
                keresett.Add(new Keres(sr.ReadLine()));
            }

            Console.WriteLine("5. feladat");
            Console.WriteLine($"Kérések száma: {keresett.Count}");

            Console.WriteLine("6. feladat");
            
        }
    }
}