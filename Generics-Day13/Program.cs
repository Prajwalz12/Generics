using System;
using System.Collections.Generic;
using System.Text;

namespace FindMax
{
    //used two different methods to find maximum number
    class MaxNumbers
    {
        int[] intNums = { 10, 30, 20 };
        public void MaxInt()
        {
            for (int i = 0; i < intNums.Length - 1; i++)
            {
                for (int j = i + 1; j < intNums.Length; j++)
                {
                    if (intNums[i] < intNums[j])
                    {
                        int temp = intNums[i];
                        intNums[i] = intNums[j];
                        intNums[j] = temp;
                    }
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < intNums.Length; i++)
            {
                Console.WriteLine(intNums[i]);
            }
        }
        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }

        //Introduced below method which used for find max string
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }

            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}