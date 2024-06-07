using System;
<<<<<<< HEAD
using System.Xml.Linq;
=======
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
>>>>>>> 6aa259e5b8ea7bb91097d77845ebf193aa3ed7f8

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
<<<<<<< HEAD
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
=======
            return num1 == num2;
>>>>>>> 6aa259e5b8ea7bb91097d77845ebf193aa3ed7f8
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

        public string GetGreeting(string name)
        {
<<<<<<< HEAD
            if (string.IsNullOrEmpty(name))
            {
                return "Hello!";
            }

            var greeting = $"Hello, {name}";

            return greeting;
=======
            if (nameOfPerson == "")
            {
                return "Whats Up?!";
            }

            else
            {
                return $"Hey hey hey, {nameOfPerson}";
            }

            return string.IsNullOrEmpty(nameOfPerson) ? "Howdie!" : $"Hey, {nameOfPerson}";

>>>>>>> 6aa259e5b8ea7bb91097d77845ebf193aa3ed7f8
        }


        public string GetHey()
        {
            return "hey!";
        }
    }
}
