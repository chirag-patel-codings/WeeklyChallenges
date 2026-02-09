using System;
using System.Data;
using System.Reflection.PortableExecutable;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
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

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int result = 0;

            int[] strLengths = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };

            result = strLengths[0];

            for (int i = 0; i < strLengths.Length; i++)
            {
                result = strLengths[i] < result ? strLengths[i] : result;
            }

            return result;
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int result = 0;
            int[] parameters = new int[] { number1, number2, number3, number4 };

            result = parameters[0];
            foreach (int parameter in parameters)
            {
                result = parameter < result ? parameter : result;
            }

            return result;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool couldFormTriangle = false;

            couldFormTriangle = (sideLength1 + sideLength2 > sideLength3)
                                    && (sideLength1 + sideLength3 > sideLength2)
                                    && (sideLength2 + sideLength3 > sideLength1);

            return couldFormTriangle;
        }

        public bool IsStringANumber(string input)
        {
            bool isStringANumber = false;

            if (!string.IsNullOrEmpty(input))
            {
                isStringANumber = double.TryParse(input, out double result);  
            }
            
            return isStringANumber;
        }

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
