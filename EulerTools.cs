using System;
using System.Collections.Generic;

public struct EulerTools
{

    public static bool IsPalindrome(int n)
    {
        string number = n.ToString();
        int left = 0;
        int right = number.Length-1;

        string leftSide = number.Substring(left, 1);
        string rightSide = number.Substring(right, 1);

        while(number.Substring(left, 1) == number.Substring(right, 1) && right >= left)
        // while(leftSide == rightSide && right >= left)
        {
            ++left;
            --right;
            // leftSide = number.Substring(++left, 1);
            // rightSide = number.Substring(--right, 1);
        }
        return number.Substring(left, 1) == number.Substring(right, 1);
    }
    public static List<int> GeneratePrimesNaive(int n)
{
    List<int> primes = new List<int>();
    primes.Add(2);
    int nextPrime = 3;
    while (primes.Count < n)
    {
        int sqrt = (int)Math.Sqrt(nextPrime);
        bool isPrime = true;
        for (int i = 0; (int)primes[i] <= sqrt; i++)
        {
            if (nextPrime % primes[i] == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            primes.Add(nextPrime);
        }
        nextPrime += 2;
    }
    return primes;
}

}