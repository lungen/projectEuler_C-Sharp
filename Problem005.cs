using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Collections;
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
        bool stop = false;
        ulong n = 200;
        int add = 20;

        while(!stop)
        {
            for (int i = add; i > 0; i--)
            {
                if(n % (ulong)i == 0)
                {
                    if(i==1)
                    {
                        Console.WriteLine("bingo: " + n);
                        stop = true;
                    }
                    continue;

                }
                else
                    break;
                
            }
            n += (ulong)add;
        }
    }
    public static IEnumerable<int> GetDividor()
    {
        for (int i = 10; i > 0; i--)
        {
            yield return i;
        }
    }

    public static IEnumerable<int> GetNumber()
    {
        int n = 0;
        while(n < 10000)
        {
            yield return n += 10;
        }

    }
    public static void Run_2()
    {
        var dividors = Problem005.GetDividor();
        var number = Problem005.GetNumber();

        var test = number.Zip(dividors, (x1, x2) => x1 % x2 == 0);
        Console.WriteLine(string.Join(", ", test));
    }

public class NumbersGenerator
{
    int limit = 0;
    public NumbersGenerator(int n)
    {
        limit = n;
    }
    public IEnumerator<int> GetEnumerator()
    {
        // IEnumerable<int> myEnum = NextNumber();
        // return myEnum.GetEnumerator();
        return NextNumber();
    }

    public IEnumerator<int> NextNumber()
    {
        for (int i = limit; i > 0; i--)
        {
            yield return i;
        }
    }
  }
}