﻿using System;
using Quick;

namespace _2._3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            var quick = new QuickSortAnalyze
            {
                NeedShuffle = false,            // 关闭打乱
                NeedPath = true                 // 显示排序轨迹
            };
            var a = QuickBest.Best(10);
            for (var i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            quick.Sort(a);
            for (var i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}