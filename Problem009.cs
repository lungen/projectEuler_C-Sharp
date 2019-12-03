/*
    Special Pythagorean triplet
   
    Problem 9

    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    a^2 + b^2 = c^2

    For example, 3^2 + 4^2 = 5^2
                    9 + 16 = 25

    There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    Find the product abc.
*/

using System;


public class Problem009 
{
    public delegate void Print(string message);

    public static void Printer(string message)
    {
        Console.WriteLine(message);
    }

    public static void Run()
    {
        Print print = Printer;

        int length = 1000;

        for (int i = 1; i <=length; i++)
        {
            for (int j  = i + 1;  j <= length;  j++)
            {
                for (int k = j + 1;  k <= length;  k++)
                {
                    if (i*i + j*j == k*k)
                    {
                        if (i + j + k == length)
                        {
                            print($"{i} + {j} + {k}");
                            print($"{i * j * k}");
                        }
                    }
                }
            }
        }
    }
}