﻿using System;
/*
You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".
*/
namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("abcdefg", "bbbaAaAg"));
        }
        static int NumJewelsInStones(string J, string S)
        {
            int Counter = 0;
            for (int i = 0; i < J.Length; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if (J[i] == S[j])
                    {
                        Counter++;
                    }
                }
            }
            return Counter;
        }
    }
}
