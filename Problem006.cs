/*
Sum square difference
   
Problem 6

The sum of the squares of the first ten natural numbers is,
1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and 
the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first 
one hundred natural numbers and the square of the sum.

*/

using System;
using System.Linq;
using System.Collections.Generic;


public class Problem006
{
    public static void Run()
    {
        int limit = 100;
        int a = MakeSumOfSquares(limit);
        int b = MakeSquareOfTheSum(limit);
        Console.WriteLine($"Sum of squares until {limit} = {a}.");
        Console.WriteLine($"Square of the sum until {limit} = {b}.");
        Console.WriteLine($"Result = {b - a}"); 
    }

    public static int MakeSumOfSquares(int limit)
    {
        int sumOfSquares = 0;

        for (int i = 1; i <= limit; i++)
        {
            sumOfSquares += i * i;
        }

        return sumOfSquares;
    }

    public static int MakeSquareOfTheSum(int limit)
    {
        int sum = 0;
        for (int i = 1; i <= limit; i++)
        {
            sum += i;
        }

        sum *= sum;

        Console.WriteLine($"Square of the sum: {sum}.");
        return sum;
    }
}