using ClientApp;
namespace ClassLibrary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();

            //Console.WriteLine("Main Menu");
            //Console.WriteLine("1. Add \n" + "2. Subtract \n" + "4. Check Prime");
            //int ch = Byte.Parse(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        Console.WriteLine(class1.Add(1, 2, 3, 4, 5, 65, 67, 7));
            //        break;
            //    case 2:
            //        int? num1 = null;
            //        int num2 = 20;
            //        num1 = Int32.TryParse(Console.ReadLine(), out int i) ? i : null;
            //        Console.WriteLine(class1.Subtract(num1, num2));

            //        break;
            //    case 3:
            //        Console.WriteLine(class1.Product(2, 3));
            //        break;
            //    case 4:
            //        Console.WriteLine(class1.CheckPrime(10));
            //        break;
            //    case 5:
            //        Console.WriteLine(class1.IsOdd(20));
            //        break;
            //    default:
            //        Console.WriteLine("Enter valid choice");
            //        break;

            //}

            //calling extended method
            //string AllEvens = class1.AllEven(2, 10);
            //Console.WriteLine(AllEvens);
            //Console.WriteLine("Print table");
            //Console.WriteLine(class1.AllTable(5));
            //Console.WriteLine(class1.TablesInRange(2,4));
            //string reversenum = class1.Reverse(2345);
            //Console.WriteLine(reversenum);
     
            //Console.WriteLine(class1.CheckPalindrome(123));
             
           // Console.WriteLine(class1.ReverseString("My name"));

            Console.WriteLine(class1.ChangeToUpper("abcdefgh my name"));
        
        
        
        
        }
    }
}