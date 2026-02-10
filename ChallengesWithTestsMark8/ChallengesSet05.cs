using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
 

        /// <summary>
        /// Finds the number that is divisible by the supplied 'n' parameter. If the checking number is lower than divisible to be found for 'n' then 'n' is returned.
        /// </summary>
        /// <param name="startNumber"></param>
        /// <param name="n"></param>
        /// <returns>Next divisible number for checking value. If start number is lower then checking value is returned.</returns>
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumberDivisibleByN = 0;
            
            if(n > startNumber)
            {
                nextNumberDivisibleByN = n;
            }
            else
            {
                nextNumberDivisibleByN = startNumber + 1;
                while(nextNumberDivisibleByN % n != 0)
                {
                    nextNumberDivisibleByN++;
                }
            }
            
            return nextNumberDivisibleByN;
        }


        /// <summary>
        /// Simply changes the values of the business names to "CLOSED" that does not have any revenues.
        /// </summary>
        /// <param name="businesses"></param>
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            
            if (businesses != null)
            {
                foreach (Business business in businesses)
                {
                    if (business.TotalRevenue == 0)
                    {
                        business.Name = "CLOSED";
                    }
                }
            }
        
        }


        /// <summary>
        /// Checks if the supplied input is in ascending order.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns true if the supplied input is in ascending order otherwise false. Returns false if no values supplied.</returns>
        public bool IsAscendingOrder(int[] numbers)
        {
            bool isAscendingOrder = false;

            if (numbers != null)
            {
                isAscendingOrder = numbers.Length > 0 ? true : false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        isAscendingOrder = false;
                        break;
                    }
                }
            }

            return isAscendingOrder;
        }


        /// <summary>
        /// Calculates the Sum of the elements those are followed by even numbers in the supplied array.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns the Sum of the elements those are followed by the even numbers in the supplied array. If no values supplied, returns '0'.</returns>
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sumElementsThatFollowAnEven = 0;

            if (numbers != null)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] % 2 == 0)
                    {
                        sumElementsThatFollowAnEven = sumElementsThatFollowAnEven + numbers[i];
                    }
                }
            }

            return sumElementsThatFollowAnEven;
        }


        /// <summary>
        /// Simply joins each elements in the supplied string (in the same order) with single space character and returns the output with '.' added at the end. 
        /// </summary>
        /// <param name="words"></param>
        /// <returns>Returns the words in the single string with space char added in-between, null & duplicting space chars removed and '.' added at the end.</returns>
        public string TurnWordsIntoSentence(string[] words)
        {
            string turnWordsIntoSentence = "";

            if (words != null)
            {
                turnWordsIntoSentence = string.Join(" ", words);

                while (turnWordsIntoSentence.Contains("  "))
                {
                    turnWordsIntoSentence = turnWordsIntoSentence.Replace("  ", " ");
                }

                turnWordsIntoSentence = turnWordsIntoSentence.Trim();

                if (turnWordsIntoSentence.Length > 0)
                {
                    turnWordsIntoSentence = $"{turnWordsIntoSentence}.";
                }
            }

            return turnWordsIntoSentence;
        }


        /// <summary>
        /// Finds and returns every 4th element from the source list. 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns>Returns every 4th element from the source list. If the source is blank/null, returns the empty array.</returns>
        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> getEveryFourthElement = new List<double>();

            if (elements != null)
            {
                if (elements.Count > 3)
                {
                    for (int i = 1; i < elements.Count; i++)
                    {
                        if ((i + 1) % 4 == 0)
                        {
                            getEveryFourthElement.Add(elements[i]);
                        }
                    }
                }
            }

            return getEveryFourthElement.ToArray();
        }


        /// <summary>
        /// Checks if the sum of the two elements (at different index positions) can equal to the targetNumber. 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="targetNumber"></param>
        /// <returns>Returs true if the sum equals to targetNumber otherwise false.</returns>
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool twoDifferentElementsInArrayCanSumToTargetNumber = false;

            if (nums != null)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                        {
                            twoDifferentElementsInArrayCanSumToTargetNumber = true;
                            break;
                        }
                    }
                }
            }

            return twoDifferentElementsInArrayCanSumToTargetNumber;
        }
    }
}
