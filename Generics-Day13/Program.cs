using System;
using System.Collections.Generic;
using System.Text;

namespace FindMax
{
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
    }
}