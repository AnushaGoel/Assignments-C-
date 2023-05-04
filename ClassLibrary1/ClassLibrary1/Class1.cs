namespace ClassLibrary1
{
    public class Class1
    {
        public int Add(params int[] num)
        {
            return num.Sum();
        }
        public int Subtract(int? num1, int? num2)       //allowing null values
        {
            num1 = num1 ?? 10;
            num2 = num2 ?? 10;
            return num1.Value - num2.Value;
        }
        public int Product(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public int MaxNum(params int[] num)
        {
            return num.Max();
        }
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }
        public bool CheckPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count==2 ? true : false;
        }

        }
    }

