﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._16
{
    /*
     * 1.4.16
     * 
     * 最接近一对（一维）。
     * 编写一个程序，给定一个含有 N 个 double 值的数组 a[]，
     * 在其中找到一对最接近的值：两者之差（绝对值）最小的两个数。
     * 程序在最坏情况下所需的运行时间应该是线性对数级别的。
     * 
     */
    class Program
    {
        //总运行时间： logN + N = N
        static void Main(string[] args)
        {
            double[] a = new double[5] { 0.1, 0.3, 0.6, 0.8, 0 };
            Array.Sort(a);//log(N)
            double minDiff = double.MaxValue;
            double minA = 0;
            double minB = 0;
            for (int i = 0; i < a.Length - 1; ++i)//N
            {
                if (a[i + 1] - a[i] < minDiff)
                {
                    minA = a[i];
                    minB = a[i + 1];
                    minDiff = a[i + 1] - a[i];
                }
            }
            Console.WriteLine($"Min Pair: {minA} {minB}, Min Value: {minDiff}");
        }
    }
}
