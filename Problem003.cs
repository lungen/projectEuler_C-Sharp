/*
Largest prime factor
   
Problem 3

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
600 851 475 143 
 */

 using System;
 using System.Collections.Generic;
 using System.Linq;

 class Problem003
 {
     static ulong largeNumber = 600851475143;
    //  static ulong largeNumber = 13195;
     public static void print(string msg)
     {
         Console.WriteLine(msg);
     }
     public static void Run()
     {
         var primeNumbers = EulerTools.GeneratePrimesNaive(10000);

        // classic solution
        int biggestDividor = 0;

        foreach(int n in primeNumbers)
        {
            if(largeNumber % (ulong)n == 0  && (ulong)n < largeNumber)
            {
                biggestDividor = (n > biggestDividor ? n : biggestDividor);
            }
        }

        print("classic solution: ");
        print("biggest dividor: " + biggestDividor);

        // linq solution
        var biggestDividorLinq = primeNumbers.Where(n => largeNumber % (ulong)n == 0).Where(n => (ulong)n < largeNumber);
        print("\nlinq solution: ");
        print("Linq: Max dividor: " + biggestDividorLinq.Max());
     }
 }