using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal static class ClassExtendedExtension
    {
        public static string AllEven(this Class1 class1,
             int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                    sb.Append(i + "\n");
            }
            return sb.ToString();
        }

        public static string AllOdd(this Class1 class1, int start,int end)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=start;i<end;i++)
            {
                if(i%2!=0)
                {
                    sb.Append(i + "\n");
                }
            }
            return sb.ToString();
        }
        public static string PrintTable(this Class1 class1, int num)
        {
            StringBuilder sb = new StringBuilder(); 
            for(int i = 1; i <=10; i++)
            {
                sb.Append(num + " * " + i + " = " + num * i + "\n");
            }
            return sb.ToString();
        }

        public static string AllTable(this Class1 class1, int num)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=1;i<=num;i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    sb.Append(i + " * " + j + " = " + i * j + "\n");
                }
            }
            return sb.ToString();

        }
        public static string TablesInRange(this Class1 class1, int startNum, int endNum)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = 1; j <= 10; j++)

                {
                    sb.Append(i + " * " + j + " = " + i * j + "\n");
                }
            }
            return sb.ToString();

        }
        public static string Reverse(this Class1 class1,int num)
        {
            string s1 = num.ToString();
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static bool CheckPalindrome(this Class1 class1, int num)
        {
            string s1 = num.ToString();
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            string s2 = new string(charArray);
            return s1 == s2? true : false;
        }

        public static string ReverseString(this Class1 class1, string str1)
        {
            char[] charArray = str1.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ChangeToUpper(this Class1 class1, string str1) {
           // char[] charArray = str1.ToCharArray();
            string str2=str1.ToUpper();
            return new string(str2);

        }
        //public static string ChangeToProperCase(this Class1 class1, string str1)
        //{
        //    string str2 = str1.ToTitleCase();
        //    return new string(str2);

        //}




        //public static string AllPrime(this Class1 class1, int start,int end)
        //{

        //    int count = 0;
        //    StringBuilder sb = new StringBuilder();
        //    for(int i=start;i<end;i++)
        //    { 
        //            if (num % i == 0)
        //            {
        //                count++;
        //            }
        //        if (count == 2)
        //        {
        //            sb.Append(i + "\n");
        //        }
        //    }
        //    return sb.ToString();
        //}
        //}




    }
}
