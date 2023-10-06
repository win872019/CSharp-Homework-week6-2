namespace try2_by_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\指定文字檔-2-九九乘法表.txt";

            string text="";

            for (int j = 1; j <= 9; j += 3)
            {

                for (int i = 1; i <= 9; i++)
                {
                    text+=$"{j}*{i}={i*j}\t{j + 1}*{i}={(j +1) * i}\t{j + 2}*{i}={(j + 2) * i}\n";

                }
                text += "\n";
            }

            File.WriteAllText(path, text);

           string readText=File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadKey();

        }
    }
}

