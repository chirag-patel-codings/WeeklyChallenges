using System;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        

        /// <summary>
        /// Returns the output by performing Sum if Even number and Substraction if Odd number for all the elements within supplied source.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Result of the Sum of Even numbers subtracted by odd numbers in the suplied source. If source is null then '0' is returned.</returns>
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        result = result + number;
                    }
                    else
                    {
                        result = result - number;
                    }
                }
            }

            return result;
        }


        /// <summary>
        /// Finds length of the shortest string within the supplied values.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <param name="str4"></param>
        /// <returns>The length of the shortest string among the supplied strings.</returns>
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int result = 0;

            // Different in the 'main' branch...
            int[] strLengths = new int[] { str1 != null ? str1.Length : 1, str2 != null ? str2.Length : 1, str3 != null ? str3.Length : 1, str4 != null ? str4.Length : 1 };

            // result = strLengths.Min();
            result = strLengths[0];

            for (int i = 0; i < strLengths.Length; i++)
            {
                result = strLengths[i] < result ? strLengths[i] : result;
            }

            return result;
        }


        /// <summary>
        /// Returns the smallest number among the supplied numbers.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <param name="number4"></param>
        /// <returns>Returns the smallest number among the supplied values.</returns>
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int result = 0;
            int[] parameters = new int[] { number1, number2, number3, number4 };

            // result = parameters.Min();
            result = parameters[0];

            foreach (int parameter in parameters)
            {
                result = parameter < result ? parameter : result;
            }

            return result;
        }

        
        /// <summary>
        /// Simply changes the Name property value of the biz object to "TrueCoders".
        /// </summary>
        /// <param name="biz"></param>
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        
        /// <summary>
        /// Checks if the supplied values of 3 lines, can form a Triangle.
        /// </summary>
        /// <param name="sideLength1"></param>
        /// <param name="sideLength2"></param>
        /// <param name="sideLength3"></param>
        /// <returns>Returns true, if they can form a Triangle otherwise false.</returns>
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool couldFormTriangle = false;

            couldFormTriangle = (sideLength1 + sideLength2 > sideLength3)
                                    && (sideLength1 + sideLength3 > sideLength2)
                                    && (sideLength2 + sideLength3 > sideLength1);

            return couldFormTriangle;
        }


        /// <summary>
        /// Checks if the supplied string is a numerical value.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns true if the supplied string is a numerical value otherwise false.</returns>
        public bool IsStringANumber(string input)
        {
            bool isStringANumber = false;

            if (!string.IsNullOrEmpty(input))
            {
                // A perfect condition for checking: 
                // ( double.TryParse(input, out double dblResult) || decimal.TryParse(input, out decimal dclResult) );
                // Will check both scientific numbers as well as hugh numerical values
                isStringANumber = double.TryParse(input, out double result);  
            }
            
            return isStringANumber;
        }


        /// <summary>
        /// Checks if the majority of elements in the supplied source array are 'null' valued.
        /// </summary>
        /// <param name="objs"></param>
        /// <returns>Returns true, if the majority of values are nulls otherwise false.</returns>
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            bool majorityOfElementsInArrayAreNull = false;

            int nullCounter = 0;
            int nonNullCounter = 0;

            if (objs != null)
            {
                foreach (object element in objs)
                {
                    if (element is null)
                    {
                        nullCounter++;
                    }
                    else
                    {
                        nonNullCounter++;
                    }
                }

                majorityOfElementsInArrayAreNull = nullCounter > nonNullCounter ? true : false;
            }

            return majorityOfElementsInArrayAreNull;
        }


        /// <summary>
        /// Calculates the Average of the Even values in the supplied source.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Returns the Average of the Even values.</returns>
        public double AverageEvens(int[] numbers)
        {
            double averageEvens = 0;
            double sumEvens = 0;
            double countEvens = 0;

            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sumEvens = sumEvens + num;
                        countEvens = countEvens + 1;
                    }
                }
                averageEvens = countEvens > 0 ? (sumEvens / countEvens) : 0;
            }

            return averageEvens;
        }


        /// <summary>
        /// Returns the Factorial value of the supplied number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Factorial of the supplied number</returns>
        /// <exception cref="ArgumentOutOfRangeException">When supplied number is Negetive, this exception is generated.</exception>
        public int Factorial(int number)
        {
            int factorial = 0;

            if (number >= 0)
            {
                if (number == 0)
                {
                    factorial = 1;
                }
                else
                {
                    factorial = number * Factorial(number - 1);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("number", number, "The number must be greater than zero");
            }
            
            return factorial;
        }
    }
}
