using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        
        
        /// <summary>
        /// Checks if the supplied char is an alphabet letter from [a-z] or [A-Z].
        /// </summary>
        /// <param name="c"></param>
        /// <returns>Returns true if its letter otherwise false.</returns>
        public bool CharacterIsALetter(char c)
        {
            
            return char.IsLetter(c) ? true : false;
        }

        
        /// <summary>
        /// Checks the supplied source contains even numbers of elements.
        /// </summary>
        /// <param name="vals"></param>
        /// <returns>Returns true if source contains even number of elements otherwise false.</returns>
        public bool CountOfElementsIsEven(string[] vals)
        {
            
            return (vals != null && vals.Length % 2 == 0) ? true : false;
        }


        /// <summary>
        /// Checks if the supplied number is Even.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns true if the supplied number is Even otherwise false.</returns>
        public bool IsNumberEven(int number)
        {
            
            return (number % 2 == 0) ? true : false;
        }


        /// <summary>
        /// Checks if the supplied number is Odd.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Returns true, if the supplied number is Odd otherwise false.</returns>
        public bool IsNumberOdd(int num)
        {
            
            return (num % 2 != 0) ? true : false;
        }


        /// <summary>
        /// Returns the sum of the Max and Min numbers of the supplied enumerable.
        /// Note: If there is only one element in the source, it is considered as both Minimum and Maximum number and Sum of it will be the double of that value.
        /// If no value is supplied then '0' is returned.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns the sum of Minimum and Maximum element value of the supplied source enumerable.</returns>
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double result = 0;

            if (numbers != null && numbers.Count() > 0)
            {
                result = numbers.Min() + numbers.Max();
            }

            return result;
        }


        /// <summary>
        /// Returns the length of the shorted string from the supplied values. If null values are supplied, then returns '0'.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>Returns the length of the shortest string among parameters.</returns>
        public int GetLengthOfShortestString(string str1, string str2)
        {
            int lengthOfStr1 = ( string.IsNullOrEmpty(str1) || string.IsNullOrWhiteSpace (str1) ) ? 0 : str1.Length;
            int lengthOfStr2 = ( string.IsNullOrEmpty(str2) || string.IsNullOrWhiteSpace (str2) ) ? 0 : str2.Length;
            
            int lengthOfShortestString = (lengthOfStr1 < lengthOfStr2) ? lengthOfStr1 : lengthOfStr2;
            
            return lengthOfShortestString;
        }


        /// <summary>
        /// Calculates the Sum of all the elements from source array. If source array is null, then '0' is returned.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns the sum of all the elements from the source array.</returns>
        public int Sum(int[] numbers)
        {
            int result = 0;

            if (numbers != null)
            {
                result = numbers.Sum();
            }
            
            return result;
        }


        /// <summary>
        /// Calculates and return the Sum of all the Even numbers in the supplied source.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns the Sum of all the Even numbers of the source.</returns>
        public int SumEvens(int[] numbers)
        {
            int result = 0;

            if (numbers != null)
            {
                result = numbers.Sum(a => (a % 2 == 0 ? a : 0));
            }
            
            return result;
        }


        /// <summary>
        /// Checks if the sum of all the elements in the supplied source turns to Odd.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns true, if the sum of elements turns to Odd otherwise false.</returns>
        public bool IsSumOdd(List<int> numbers)
        {
            bool result = false;

            if (numbers != null)
            {
                result = (numbers.Sum() % 2 == 0) ? false : true;
            }
            
            return result;
        }

        
        /// <summary>
        /// Returns the counts of the positive odd numbers that are below the supplied number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns the counts of the positive odd numbers below supplied number.</returns>
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long countOfPositiveOdds = 0;
            
            if (number > 0)
            {
                countOfPositiveOdds = number / 2;
            }
            
            return countOfPositiveOdds;
        }
    }
}
