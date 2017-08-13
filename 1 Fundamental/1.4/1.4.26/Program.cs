﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._26
{
    /*
     * 1.4.26
     * 
     * 三点共线。
     * 假设有一个算法，接受平面上的 N 个点并能够返回在同一直线上的三个点的组数。
     * 证明你能够用这个算法解决 3-sum 问题。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //证明 (a, a^3) (b, b^3) (c, c^3) 当且仅当 a + b + c = 0 时共线。
            //
            //若 (a, a^3) (b, b^3) (c, c^3) 共线，则根据直线两点式有：
            //(y - b^3)/(a^3 - b^3) = (x - b)/(a - b)
            //带入第三个点，有：
            //(c^3 - b^3)/(a^3 - b^3) = (c - b)/(a - b)
            //解方程有：
            //c = -a - b
            //得证。
        }
    }
}