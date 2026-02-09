using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result = (char.IsLetter(c) ? true : false);
            return result;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            bool result = (vals != null && vals.Length % 2 == 0) ? true : false;
            return result;
        }

        public bool IsNumberEven(int number)
        {
            bool result = (number % 2 == 0) ? true : false;
            return result;
        }

        public bool IsNumberOdd(int num)
        {
            bool result = (num % 2 != 0) ? true : false;
            return result;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double result = 0;

            if (numbers != null && numbers.Count() > 0)
            {
                result = numbers.Min() + numbers.Max();
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int lengthOfStr1 = ( string.IsNullOrEmpty(str1) || string.IsNullOrWhiteSpace (str1) ) ? 0 : str1.Length;
            int lengthOfStr2 = ( string.IsNullOrEmpty(str2) || string.IsNullOrWhiteSpace (str2) ) ? 0 : str2.Length;
            
            int lengthOfShortestString = (lengthOfStr1 < lengthOfStr2) ? lengthOfStr1 : lengthOfStr2;
            
            return lengthOfShortestString;
        }

        public int Sum(int[] numbers)
        {
            int result = 0;

            if (numbers != null)
            {
                result = numbers.Sum();
            }
            
            return result;
        }

        public int SumEvens(int[] numbers)
        {
            int result = 0;

            if (numbers != null)
            {
                result = numbers.Sum(a => (a % 2 == 0 ? a : 0));
            }
            
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            bool result = false;

            if (numbers != null)
            {
                result = (numbers.Sum() % 2 == 0) ? false : true;
            }
            return result;
        }

        
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
