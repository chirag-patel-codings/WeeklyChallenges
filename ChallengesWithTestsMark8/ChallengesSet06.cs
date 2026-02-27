using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            
            return words?.Contains(word, ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal) ?? false;
        }

        public bool IsPrimeNumber(int num)
        {
            
            bool isPrimeNumber = true;

            if (num <= 1 || (num != 2 && num % 2 == 0))
            {
                isPrimeNumber = false;
            }
            else if (num >= 3)
            {
                for (int i = 3; i <= Math.Sqrt(num); i += 2)
                {
                    if (num % i == 0)
                    {
                        isPrimeNumber = false;
                    }
                }
            }
            
            return isPrimeNumber;
        }

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

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            
            return elements?.Where((e, index) => (n > -1 && (index + 1) % n == 0)).ToArray() ?? new double[] {};
        }
    }
}
