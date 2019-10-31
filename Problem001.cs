using System.Globalization;
using System;
using System.Linq;

class Problem001
{
    /*
    Multiples of 3 and 5
   
    Problem 1

    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    The sum of these multiples is 23.

    Find the sum of all the multiples of 3 or 5 below 1000.
     */

    public void Run()
    {
        Console.WriteLine("Problem 1:");

        int lim = 1000-1;
        int sum = 0;

        int[] numbers = new int[lim];

        for (int i = 0; i < lim; i++)
        {
            numbers[i] = i + 1;
        }

        var results = from n in numbers
                        where (n % 3) == 0 || (n%5) == 0
                        select n;

        foreach(var n in results)
        {
            // Console.Write("{0} ", n);
            sum += n;
        }
        Console.Write("Result: {0}", sum);
    }

}
