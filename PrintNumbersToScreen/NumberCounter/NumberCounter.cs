using System;
using System.Collections.Generic;

namespace NumberCounter
{
    public static class NumberCounter
    {
        /// <summary>
        /// This method prints numbers from 1 to an upperbound value.  While counting up,
        /// if the number is divisible by 3 display FirstName.  If the number is divisible by
        /// 5 display LastName.  I the number is divisible by 3 and 5, display FirstName and LastName.
        /// If an upperbound less than 1 is supplied an exception is thrown.
        /// </summary>
        /// <param name="upperBound">Number to count up to</param>
        /// <param name="FirstName">Identifier to indicate number was divisible by 3</param>
        /// <param name="LastName">Identifier to indicate a number was divisible by 5</param>        /// 
        /// <returns>List of Strings representing the count</returns>
        public static List<String> PrintNumbers(Int64 upperBound, string FirstName, string LastName)
        {
            List<String> result = new List<String>();

            if (upperBound <= 0)
            {
                throw new Exception("upperBound must be greater than 0");
            }

            for (int x = 1; x <= upperBound; x++)
            {
                if (isDivisibleBy3(x) & !isDivisibleBy5(x))
                {
                    result.Add(FirstName);
                }
                else if (!isDivisibleBy3(x) & isDivisibleBy5(x))
                {
                    result.Add(LastName);
                }
                else if (isDivisibleBy3(x) & isDivisibleBy5(x))
                {
                    result.Add(FirstName + " " + LastName);
                }
                else
                {
                    result.Add(x.ToString());
                }
            }

            return result;
        }

        /// <summary>
        /// Helper method for doing the divisible by 3 test.  Split out
        /// to better facilitate unit testing.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool isDivisibleBy3(int number)
        {
            return (number % 3 == 0);
        }

        /// <summary>
        /// Helper method for doing the divisible by 5 test.  Split out
        /// to better facilitate unit testing.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool isDivisibleBy5(int number)
        {
            return (number % 5 == 0);
        }
    }
}
