using System.Security.Cryptography;
/*
Smallest multiple
   
Problem 5

2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

using System;
using System.Linq;
using System.Collections.Generic;

class Problem005
{
    public static void Run()
    {
        ulong result = 1;

        int n = 1;

        // get the maximal number
        while(n<=10)
        {
            result *= (ulong)n;
            Console.WriteLine("n: {0}. result: {1}", n, result);
            n++;
        }
        while(result > 100)
        {
            Console.WriteLine(ModuloResult(result, 10));
            result -= 100;
        }

/* 
        ulong newResult = result;

        while(newResult % (ulong)20 == 0)
        {
            newResult = newResult / (ulong)20;
            Console.WriteLine(newResult);

            while(newResult % (ulong)19 == 0)
            {
                newResult = newResult / (ulong)19;
                Console.WriteLine(newResult);
            }
        }
        */

        ulong ModuloResult(ulong number, int modulo)
        {
            if(modulo == 1)
            {
                // Console.WriteLine("fin recursion");
                Console.WriteLine("Number: {0}, modulo: {1}", number, modulo);
                return number;
            }

            ulong newNumber = number;

            while(newNumber % (ulong)modulo == 0)
            {
                Console.WriteLine("Number: {0}, modulo: {1}", newNumber, modulo);
                newNumber = newNumber / (ulong)modulo;
                return ModuloResult(newNumber, modulo-1);
            }
                // return number * ModuloResult(result, modulo-1);
                // return number * ModuloResult((number / (ulong)modulo), modulo-1);
                return ModuloResult(newNumber, modulo-1);
        }
    }
}