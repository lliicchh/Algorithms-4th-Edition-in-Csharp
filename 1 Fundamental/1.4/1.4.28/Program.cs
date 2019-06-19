﻿using System;

namespace _1._4._28
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new QueueStack<string>();
            var input = "to be or not to - be - - that - - - is".Split(' ');

            foreach (var s in input)
            {
                if (s == "-")
                {
                    Console.WriteLine(stack.Pop());
                }
                else
                {
                    stack.Push(s);
                }
            }
        }
    }
}
