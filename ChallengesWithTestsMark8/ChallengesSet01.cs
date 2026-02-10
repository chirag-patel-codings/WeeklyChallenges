using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        
        
        /// <summary>
        /// Checks if the supplied two numbers are same.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns true, if the supplied two numbers are same otherwise false.</returns>
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            
            return num1 == num2;
        }


        /// <summary>
        /// Subtracts the 'minuend' from 'subtrahend' and returns the result.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns>Returns the result of subtraction from minuend with subtrahend.</returns>
        public double Subtract(double minuend, double subtrahend)
        {
            
            return minuend - subtrahend;
        }


        /// <summary>
        /// Adds the two numbers.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns the result of Sum of two numbers.</returns>
        public int Add(int number1, int number2)
        {
            
            return number1 + number2;
        }


        /// <summary>
        /// Finds the smallest number among supplied values.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Returns the smallest number among the supplied values.</returns>
        public int GetSmallestNumber(int number1, int number2)
        {
            
            return number1 < number2 ? number1 : number2;
        }


        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="factor1"></param>
        /// <param name="factor2"></param>
        /// <returns>Returns the result of Multiplication from the supplied values.</returns>
        public long Multiply(long factor1, long factor2)
        {
            
            return factor1 * factor2;
        }


        /// <summary>
        /// Generates a Greeting string with the supplied nameOfPerson.
        /// </summary>
        /// <param name="nameOfPerson"></param>
        /// <returns>Returns the Greeting by adding "Hello" at the begining and Exclamation at the end, to the nameOfPerson if supplied otherwise returns 'Hello!'.</returns>
        public string GetGreeting(string nameOfPerson)
        {
            
            return $"Hello{((string.IsNullOrWhiteSpace(nameOfPerson) || string.IsNullOrEmpty (nameOfPerson) ) ? "" : ", " + nameOfPerson)}!";
        }


        /// <summary>
        /// Simply returns the 'HEY!'.
        /// </summary>
        /// <returns>Returns 'HEY!'.</returns>
        public string GetHey()
        {
            
            return "HEY!";
        }
    }
}
