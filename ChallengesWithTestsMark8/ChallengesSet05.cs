using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {

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
