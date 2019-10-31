/*
Largest palindrome product
Problem 4

A palindromic number reads the same both ways. 
The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
 */

 using System;
 using System.Collections.Generic;
 using System.Linq;

 class Problem004
 {
     public static void Run()
     {
         int n1 = 999;
         int n2 = 999;
         int maxPalindrome = 0;
         List<int> results = new List<int>();

         while(n1 >= 100)
         {
             while(n2 >= 100)
             {
                 int result = n1 * n2;
                 // for linq
                 results.Add(result);

                 bool testPalindrome = EulerTools.IsPalindrome(result);
                //  Console.WriteLine(testPalindrome + ": " + result + " " + n1 + " x " + n2);
                 if(testPalindrome)
                 {
                    maxPalindrome = (result > maxPalindrome) ? result : maxPalindrome;
                    // Console.WriteLine("palindrome: {0}. n1: {1}, n2: {2}. max palindrome: {3}", result, n1, n2, maxPalindrome);
                 }
                 n2--;
             }
             n1--;
             n2 = 999;
         }

         Console.WriteLine("fin classic: ");
         Console.WriteLine("max palindrome: " + maxPalindrome);

         var palindromeResults = results.Where(n => EulerTools.IsPalindrome(n));

         Console.WriteLine("fin linq: ");
         Console.WriteLine("max palindrome: " + palindromeResults.Max());

     }
 }