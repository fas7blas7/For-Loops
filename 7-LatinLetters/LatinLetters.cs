﻿namespace _7_LatinLetters
{
    internal class LatinLetters
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            for(char i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}