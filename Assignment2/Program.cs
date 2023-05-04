using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

internal class Assign
{
    public static int matrixsum()
    {
        int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] result = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        Console.WriteLine("Addition");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(result[i, j] + " ");
            }
        }
        return 0;
    }
    public static int columsum()
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int[] sums = new int[cols];


        for (int j = 0; j < cols; j++)
        {

            for (int i = 0; i < rows; i++)
            {
                sums[j] += arr[i, j];
            }


            Console.WriteLine("Sum of column " + (j + 1) + ": " + sums[j]);
        }
        return 0;
    }
    public static int rowsum()
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int[] sums = new int[cols];


        for (int j = 0; j < cols; j++)
        {

            for (int i = 0; i < rows; i++)
            {
                sums[j] += arr[j, i];
            }


            Console.WriteLine("Sum of row " + (j + 1) + ": " + sums[j]);
        }
        return 0;
    }

    public static int max()
    {
        int[] array = { 3, 5, 1, 9, 7, 4 };

        // Setting first element as the maximum
        int max = array[0];


        for (int i = 1; i < array.Length; i++)
        {

            if (array[i] > max)
            {
                max = array[i];
            }
        }

       
        Console.WriteLine("The maximum element is: " + max);
        return 0;

    }


    static void Main(string[] args)
    {      //1st Quest
           //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           //int sum = 0;
           //float avg = 0;
           //for (int i = 0; i < arr.Length; i++)
           //{
           //    sum = sum + arr[i];
           //}
           //avg = sum / arr.Length;
           //Console.WriteLine("Sum is" + sum);
           //Console.WriteLine("Average is" +  avg);


        ////2nd Quest
        //int[,] arr = { { 1, 2, 3, },{ 4, 5, 6 }, { 7, 8, 9 } };
        //int sum = 0;
        //for (int i = 0; i < 3; i++)
        //{
        //    for(int j = 0; j <3; j++)
        //    {
        //        sum += arr[][];
        //    }
        //}
        //Console.WriteLine("Sum is"+ sum);

        


            Console.WriteLine("Hello World!");
            //arraysum();
            matrixsum();
            //rowsum();
            //columsum();
            //max();

        }
    }








