using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    static class ExtentionMethods
    {
        public static bool IsOdd(int num)
        {
            if (num % 2 != 0)
                return true;

            return false;
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;

            return false;
        }

        public static bool IsContainsDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }
            return false;
        }

        public static string ToCapitalize(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            str = str.ToLower();
            string newStr = char.ToUpper(str[0]) + str.Substring(1);
            return newStr;

        }

        public static int[] GetValueIndexes(string str, char chr)//bu metodu catdira bilmedim
        {
            int[] arr;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    int arr[i] = i;
                }
            }
            return 
        }
    }
}
