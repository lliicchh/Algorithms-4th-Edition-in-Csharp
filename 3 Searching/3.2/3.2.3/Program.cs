﻿namespace _3._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 官方答案：第一个插入的是 H，且 C 在 A 和 E 之前插入，S 在 R 和 X 之前插入的树。
            // 对序列排序，得到 A C E H R S X 。
            // 于是 H 为根结点，C 和 S 分别为 H 的子结点，
            // A 和 E 为 C 的子结点，R 和 X 为 S 的子结点。
        }
    }
}