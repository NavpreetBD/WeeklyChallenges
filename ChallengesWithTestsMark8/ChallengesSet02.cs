﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c); // build in method
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers) //(I)Enumerable= mention ( a number of things one by one)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max(); ;     // using linq build in methods
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)   // linq can also be used
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }

            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0; // using linq
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
