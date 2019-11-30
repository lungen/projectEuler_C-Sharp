/*
    10001st prime
    
    Problem 7

    By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10 001st prime number?
*/

using System;
using System.Linq;
using System.Collections.Generic;


public class Problem007
{
    public static void Run()
    {
        int limit = 10001;

        var primeList  = EulerTools.GeneratePrimesNaive(100000);
        Console.WriteLine($"len of prime-list: {primeList.Count}");
        // Console.WriteLine($"last prime: {primeList[primeList.Count- 1]}");
        Console.WriteLine($"last prime: {primeList[10001]}");
    }
}