﻿using System;

namespace SymbolTable
{
    /// <summary>
    /// 测试 BinarySearchST 的用例。
    /// </summary>
    public class TestBinarySearchST
    {
        /// <summary>
        /// 测试方法，测试 BinarySearchST。
        /// </summary>
        /// <param name="st">用于测试的符号表。</param>
        public static void Test(BinarySearchST<string, int> st)
        {
            string test = "S E A R C H E X A M P L E";
            string[] keys = test.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = keys.Length;

            for (int i = 0; i < n; i++)
                st.Put(keys[i], i);

            Console.WriteLine("size = " + st.Size());
            Console.WriteLine("min = " + st.Min());
            Console.WriteLine("max = " + st.Max());
            Console.WriteLine();

            Console.WriteLine("Testing Keys()");
            Console.WriteLine("-----------------------------------");
            foreach (string s in st.Keys())
                Console.WriteLine(s + " " + st.Get(s));
            Console.WriteLine();

            Console.WriteLine("Testing Select()");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < st.Size(); i++) // 循环条件不能有 '='
                Console.WriteLine(i + " " + st.Select(i));
            Console.WriteLine();

            Console.WriteLine("key Rank Floor Ceil");
            Console.WriteLine("-----------------------------------");
            for (char i = 'A'; i <= 'Z'; i++)
            {
                string s = i + "";
                Console.WriteLine($"{s} {st.Rank(s)} {st.Floor(s)} {st.Ceiling(s)}");
            }
            Console.WriteLine();

            for (int i = 0; i < st.Size() / 2; i++)
                st.DeleteMin();
            Console.WriteLine("After deleting the smallest " + st.Size() / 2 + " keys"); 
            Console.WriteLine("-----------------------------------");
            foreach (string s in st.Keys())
                Console.WriteLine(s + " " + st.Get(s));
            Console.WriteLine();

            while (!st.IsEmpty())
                st.Delete(st.Select(st.Size() / 2));
            Console.WriteLine("After deleting the remaining keys");
            Console.WriteLine("-----------------------------------");
            // 异常处理
            try
            {
                foreach (string s in st.Keys())
                    Console.WriteLine(s + " " + st.Get(s));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            Console.WriteLine();

            Console.WriteLine("After adding back N keys");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < n; i++)
                st.Put(keys[i], i);
            foreach (string s in st.Keys())
                Console.WriteLine(s + " " + st.Get(s));
            Console.WriteLine();
        }
    }
}
