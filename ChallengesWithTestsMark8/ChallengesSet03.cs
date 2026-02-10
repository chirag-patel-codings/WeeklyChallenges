using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {

        
        /// <summary>
        /// Checks the supplied values if they contains 'false' value.
        /// </summary>
        /// <param name="vals"></param>
        /// <returns>true: if the supplied values has 'false' value otherwise false.</returns>
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool result = false;

            if (vals != null)
            {
                result = vals.Contains(false);
            }

            return result;
        }


        /// <summary>
        /// Checks if the sum of the Odd numbers within its list values turns to Odd.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns true if the result truns to Odd other false.</returns>
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool result = false;

            if (numbers != null)
            {
                result = (numbers.Sum(a => a % 2 != 0 ? a : 0)) % 2 != 0;
            }

            return result;
        }


        /// <summary>
        /// Validates if the supplied password string contains atleast one Uppercase, Lowercase and Number letters within it.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>Returns true if it contains Uppercase, Lowercase and Number within otherwise false.</returns>
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool result = false;

            if (password.Length > 0)
            {
                bool hasUpper = password.Any(p => char.IsUpper(p));     // bool hasUpper = password.Any(char.IsUpper);
                bool hasLower = password.Any(p => char.IsLower(p));
                bool hasNumber = password.Any(p => char.IsNumber(p));

                result = hasUpper && hasLower && hasNumber;
            }

            return result;
        }


        /// <summary>
        /// Simples returns the First Letter of the string.
        /// </summary>
        /// <param name="val"></param>
        /// <returns>First letter within supplied string.</returns>
        /// <exception>null strings will fail this function!</exception>
        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }


        /// <summary>
        /// Simples returns the Last Letter of the string.
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Last letter within supplied string.</returns>
        /// <exception>null strings will fail this function!</exception>
        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }


        /// <summary>
        /// Divides dividend by divisor and returns the result.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns>Result of divide operation. Will return '0' if divisor is '0'.</returns>
        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result = 0;

            if (divisor != 0)
            {
                result = (dividend / divisor);
            }

            return result;
        }

       
        /// <summary>
        /// Subtracts first element value from the last element and returns the result.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Result of subtraction from the last element of the first element. Returns zero when no values supplied in nums.</returns>
        public int LastMinusFirst(int[] nums)
        {
            int result = 0;

            if (nums != null && nums.Length > 0)
            {
                result = nums[nums.Length - 1] - nums[0];
            }

            return result;
        }

        
        /// <summary>
        /// Simply returns the Odd numbers under 100.
        /// </summary>
        /// <returns>Array of odd numbers under 100.</returns>
        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }


        /// <summary>
        /// Changes the words of the supplied string to UPPERCASE.
        /// </summary>
        /// <param name="words"></param>
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
