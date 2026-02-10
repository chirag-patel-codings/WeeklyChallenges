using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {


        /// <summary>
        /// Checks if the Enumerable contains the supplied word.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="word"></param>
        /// <param name="ignoreCase">Flag to ignore the cases of the source strings and checking word.</param>
        /// <returns>Returns true if the checking word is found in the source string enumerable.</returns>
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var collectionContainsWord = false;
            
            if (words != null)
            {
                collectionContainsWord = words.Contains(word, ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal);
                // collectionContainsWord = words.Any(w => ignoreCase ? w?.ToLower() == word?.ToLower() : w == word);       // Also works perfectly when 'null' values are part of the input and output strings...
            }
            
            return collectionContainsWord;
        }


        /// <summary>
        /// Checks if the supplied number is a Prime number (in Math).
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Returns true if the supplied number is a Prime number otherwise false.</returns>
        public bool IsPrimeNumber(int num)
        {
            bool isPrimeNumber = true;
            
            switch (num)
            {
                case <= 1:
                case int when (num != 2 && num % 2 == 0):           // Even numbers excluding '2'
                    isPrimeNumber = false;
                    break;
                case 2:
                    isPrimeNumber = true;
                    break;
                case >= 3:
                    for (int i = 3; i <= Math.Sqrt(num); i += 2)    // iterate through all the Odd numbers until Square-Root of the supplied 'num'.
                    {
                        if (num % i == 0)
                        {
                            isPrimeNumber = false;
                        }
                    }
                    break;
            }

            return isPrimeNumber;
        }


        /// <summary>
        /// Returns the index position (start from '0') of the last letter that is Unique within the supplied string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Index position ('0' based) of the last unique letter.</returns>
        public int IndexOfLastUniqueLetter(string str)
        {
            int indexOfLastUniqueLetter = -1;
            bool isLetterUnique = true;
            List<char> nonUniqueLetters = new List<char>();

            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (nonUniqueLetters.Contains(str[i]))
                    {
                        continue;
                    }
                    else
                    {
                        isLetterUnique = true;
                        for (int j = i + 1; j < str.Length; j++)
                        {
                            if (str[i] == str[j])
                            {
                                nonUniqueLetters.Add(str[i]);
                                isLetterUnique = false;
                            }
                        }
                        if (isLetterUnique)
                        {
                            indexOfLastUniqueLetter = i;
                        }
                    }
                }
            }

            return indexOfLastUniqueLetter;
        }


        /// <summary>
        /// Returns the max count for the elements that are consicutive within supplied array.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Max count of the consicutive elements.</returns>
        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxConsecutiveCount = 0;
            int consecutiveCount = 0;
            
            if (numbers != null)
            {
                for(int i = 1; i < numbers.Length; i++)
                {
                    if(numbers[i] == numbers[i - 1])
                    {
                        consecutiveCount = consecutiveCount == 0 ? 2 : consecutiveCount + 1;
                        maxConsecutiveCount = consecutiveCount > maxConsecutiveCount  ? consecutiveCount : maxConsecutiveCount;
                    }
                    else
                    {
                        consecutiveCount = 0;
                    }
                }
            }

            return maxConsecutiveCount;
        }


        /// <summary>
        /// Returns the list of elements that are at every nth position in the supplied list.
        /// </summary>
        /// <param name="elements">Source.</param>
        /// <param name="n">Element to find at position.</param>
        /// <returns>List of elements at every nth (specified) position.</returns>
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> getEveryNthElement = new List<double>();
            
            if(elements != null)
            {
                getEveryNthElement = elements.Where((index, e) => (n > -1 && (index) % n == 0)).ToList();       // (For some reason 'index' starts at '1' in 'Where' Linq Function)
            }

            return getEveryNthElement.ToArray();
        }
    }
}
