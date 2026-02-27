using System;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            return numbers.Sum(a => a % 2 == 0 ? a : (-1 * a));
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            return new int[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {

            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            
            return (sideLength1 + sideLength2 > sideLength3)
                   && (sideLength1 + sideLength3 > sideLength2)
                   && (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
           
            return ( double.TryParse(input, out double oResult) || decimal.TryParse(input, out decimal eResult) );  
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            // return ( objs.Where(n => n == null).Count() > objs.Where(o => o != null).Count() );
            
            return objs.Sum(o => o == null ? 1 : -1) > 0;
        }
       
        public double AverageEvens(int[] numbers)
        {

            var evenNumbers = numbers != null ? numbers.Where(num => num % 2 == 0) : new int[] {0};
            return evenNumbers.Count() > 0 ? evenNumbers.Average() : 0;
        }

        public int Factorial(int number)
        {
            
            return (number >= 0) ? (number == 0 ? 1 : Enumerable.Range(1, number).Aggregate((a, b) => a * b))
                    : throw new ArgumentOutOfRangeException("number", number, "The number must be greater than zero");
        }

    }
}
