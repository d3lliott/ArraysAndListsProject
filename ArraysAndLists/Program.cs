using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();

            var odds = new List<int>();
            // method 1
            //for (int i=0; i < r.Length; i++)
            //{
            //    if (r [i] % 2 ==00)
            //    {
            //        evens.Add(r[i]);
            //    }
            //    else
            //    {
            //        odds.Add(r[i]);
            //    }

            //}

            //method 2, outputs the same as method 1
            foreach (var num in r)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                    //could Console.WriteLine here to eliminate second set of code
                }
                else
                {
                    odds.Add(num);
                    //could Console.WriteLine here to eliminate second set of code
                }
            }
            
            //for loops that write out the numbers. the Console.WriteLine sections in these
            // loops could just be moved into the earlier code to make the second set 
            // of foreach (the ones below) unneccessary. 
            foreach ( var i in evens)
            {
                Console.WriteLine($"{i} is an even number");
            }
            foreach (var i in odds)
            {
                Console.WriteLine($"{i} is an odd number");
            }

        



            
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
