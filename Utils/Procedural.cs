﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Procedural
    {
        public static T_out[] Map<T_in, T_out>(Func<T_in, T_out> convert, T_in[] lox)
        {
            var result = new T_out[lox.Length];
            for(int i = 0; i < lox.Length; i++)
            {
                result[i] = convert(lox[i]);
            }

            return result;
        }

        public static T[] Filter<T>(Func<T, bool> satisfy, T[] lox)
        {
            var result = new T[](lox.Count);
            var keep = new int[lox.Length];
            int ki = 0;
            foreach (int i = 0; i < lox.Length; i++)
            {
                if (satisfy(lox[int]))
                {

                }
            }

            return lox;
        }
    }
}
