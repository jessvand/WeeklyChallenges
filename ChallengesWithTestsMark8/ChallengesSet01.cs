using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
        }
        public double Subtract(double minuend, double subtrahend)
        {
            var result = minuend - subtrahend;
            return result;
        }

        public int Add(int number1, int number2)
        {
            var addResult = number1 + number2;
            return addResult;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }

            else
            {
                return number2;
            }
        }


        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Whats Up?!";
            }

            else
            {
                return $"Hey hey hey, {nameOfPerson}";
            }

            return string.IsNullOrEmpty(nameOfPerson) ? "Howdie!" : $"Hey, {nameOfPerson}";

        }


        public string GetHey()
        {
            return "hey!";
        }
    }
}
