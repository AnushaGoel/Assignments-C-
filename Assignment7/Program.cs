

namespace Assignment7
{
    internal class Assgnmnt7
    {
        public static void Main()
        {
            {
                Console.WriteLine("Start");
                //if (!Directory.Exists("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo"))
                //{
                //    Directory.CreateDirectory("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo");
                //}

                ////Directory.CreateDirectory("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1");
                ////Directory.CreateDirectory("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2");

                ////File.Create("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt");
                ////FileInfo fs = new FileInfo("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt");
                // //fs.Create();


                ////string str = "My name is xyz";
                ////File.AppendAllText("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt", str);
                ////string str1 = "My name is ABc";
                ////File.AppendAllText("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt", str1);

                ////string str2 = "Second by info";
                ////FileInfo.AppendAllText("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt",str2);

                ////string[] list = Directory.GetDirectories("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo");
                ////foreach (string item in list)
                ////{
                ////    Console.WriteLine(item);
                ////}
                ////File.Copy("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt", "C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo2\\file2.txt");
                ////Console.WriteLine(Directory.GetCreationTime("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo"));

                // File.Delete("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\demo1\\file1.txt");

                FileStream fs = new FileStream("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\text3.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);

                writer.WriteLine("Hi this is a file");
                writer.Close();

                fs = new FileStream("C:\\Users\\Anusha.Goel\\source\\repos\\Assignment1\\Assignment7\\demo\\text3.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs);
                Console.WriteLine(reader.ReadToEnd());
                string line = reader.ReadLine();
                while (line != null)
                       {
                         Console.WriteLine(line);
                           line = reader.ReadLine();
                        }
                   reader.Close();
      

            }

        }
    }
}