﻿using System;

namespace _2._5._14
{
    class Program
    {
        static void Main(string[] args)
        {
            var domains = new Domain[5];
            domains[0] = new Domain("edu.princeton.cs");
            domains[1] = new Domain("edu.princeton.ee");
            domains[2] = new Domain("com.google");
            domains[3] = new Domain("edu.princeton");
            domains[4] = new Domain("com.apple");
            Array.Sort(domains);
            for (var i = 0; i < domains.Length; i++)
            {
                Console.WriteLine(domains[i]);
            }
        }
    }
}
