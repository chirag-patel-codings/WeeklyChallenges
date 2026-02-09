using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool result = false;

            if (vals != null)
            {
                result = vals.Contains(false);
            }
            
            return result;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool result = false;
            
            if (numbers != null)
            {
                result = (numbers.Sum(a => a % 2 != 0 ? a : 0)) % 2 != 0;
            }

            return result;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool result = false;
            
            if (password.Length > 0)
            {
                bool hasUpper = password.Any(char.IsUpper);
                bool hasLower = password.Any(char.IsLower);
                bool hasNumber = password.Any(char.IsNumber);

                result = hasUpper && hasLower && hasNumber;
            }

            return result;
        }

        public char GetFirstLetterOfString(string val)
        {
            char result = val[0];
            return result;
        }

        public char GetLastLetterOfString(string val)
        {
            char result = val[val.Length-1];
            return result;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result = 0;
            if (divisor != 0)
            {
                result = (dividend / divisor);
            }
            
            return result;
        }


        public int LastMinusFirst(int[] nums)
        {
            int result = 0;

            if (nums != null && nums.Length > 0)
            {
                result = nums[nums.Length - 1] - nums[0];
            }
            return result;
        }

        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();

            for(int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }


        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words != null)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = ( string.IsNullOrEmpty(words[i]) || string.IsNullOrWhiteSpace(words[i]) )
                                ? words[i]
                                : words[i].ToUpper();
                }
            }
        }
    }
}
