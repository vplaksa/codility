﻿using System;

namespace codility
{
    class Solution
    {
        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //make array of indicators where +1 is green and -1 is red

            int[] ind = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                    ind[i] = +1; //green
                else
                    ind[i] = -1; //red;
            }
            //ok, lets find index for which number of +1 in left  fits number of -1 right 

            int border = 0;
            for (border = 0; border < ind.Length; border++)
            {
                int numberOfGreenLeft = 0;
                int numberOfRedLeft = 0;

                int numberOfGreenRight = 0;
                int numberOfRedRight = 0;

                //current left part
                for (int i = 0; i <= border; i++) //inclusive
                {
                    if (ind[i] >= 0)
                        numberOfGreenLeft += ind[i];
                    else
                        numberOfRedLeft += ind[i];
                }

                //current right part
                for (int i = border + 1; i < ind.Length; i++) //inclusive
                {
                    if (ind[i] >= 0)
                        numberOfGreenRight += ind[i];
                    else
                        numberOfRedRight += -1 * ind[i];
                }

                //check if satisfied
                if (numberOfGreenLeft == numberOfRedRight)
                    return border + 1; //when index is three, desired num is 4
            }

            return border + 1;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            var c = new Solution();
            //var d = c.solution(5, new int[] { 5, 5, 1, 7, 2, 3, 5 }); //
            //Console.WriteLine(d);
            var k = c.solution(6, new int[] { 6, 5, 4, 3, 2, 1 }); //5
            Console.WriteLine(k);

            var e = c.solution(7, new int[] { 6, 5, 4, 3, 2, 1 }); //6
            Console.WriteLine(e);

            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
