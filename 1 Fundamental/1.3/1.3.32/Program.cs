﻿using System;

namespace _1._3._32
{    
    class Program
    {
        // 见 Steque.cs
        static void Main(string[] args)
        {
            var steque = new Steque<string>();
            steque.Push("first");
            steque.Push("second");
            steque.Push("third");
            steque.Enqueue("fourth");
            Console.WriteLine(steque.ToString());
            steque.Pop();
            steque.Pop();
            steque.Pop();
            steque.Pop();
            Console.WriteLine(steque.ToString());
            steque.Enqueue("first");
            steque.Push("zero");
            Console.WriteLine(steque.ToString());
        }
    }
}
