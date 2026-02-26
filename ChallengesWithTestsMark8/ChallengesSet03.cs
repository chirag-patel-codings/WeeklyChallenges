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
            
            return vals?.Contains(false) ?? false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            return (numbers == null ? false : (numbers.Sum(a => a % 2 != 0 ? a : 0)) % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
            return (password.Length > 0) ? (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            // return val[^1];
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {

            return divisor == 0 ? 0 : (dividend / divisor);
        }

        public int LastMinusFirst(int[] nums)
        {
            
            return (nums == null || nums.Length == 0) ? 0 : (nums[^1] - nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            
            return Enumerable.Range(1, 100).Where(e => e % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            
            if (words != null)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = (string.IsNullOrEmpty(words[i]) || string.IsNullOrWhiteSpace(words[i]))
                                ? words[i]
                                : words[i].ToUpper();
                }
            }
        }
    }
}
