﻿namespace _2_FirstXNumbersSum
{
    internal class FirstXNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;

                if(i < n)
                {
                    Console.Write(i + "+");
                }
                else
                {
                    Console.Write(i + "=");
                }
            }          

            Console.WriteLine(sum);
        }
    }
}