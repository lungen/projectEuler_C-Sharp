/*
Smallest multiple
   
Problem 5

2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

class Problem005
{


/// <summary>
/// classic solution
/// </summary>
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

    public static ulong GetMaxNumber()
    {
        int counter = 20;
        ulong number = 1;

        while(counter > 0 )
        {
            number *= (ulong)counter;
            counter--;
        }

        Console.WriteLine("Max ulong number: " + number);

        return number;
    }
    public static IEnumerable<int> GetDivider()
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
        var Dividers = Problem005.GetDivider();
        var number = Problem005.GetNumber();

        var test = from n in number
                    from d in Dividers
                    where n % d == 0
                    select new {
                        Name = n.ToString(),
                        Dividers = d                    
                    };

        var test2 = from result in test 
                    group result by result.Name;


        // Console.WriteLine(string.Join(", ", test));
        foreach(var k in test2)
        {
            if(k.Count() == 10)
            {
                Console.WriteLine(k.Key + " " +  k.Count());
                foreach(var v in k)
                    Console.WriteLine(v);
            }
        }
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