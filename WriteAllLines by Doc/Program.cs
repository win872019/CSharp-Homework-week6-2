
namespace WriteAllLines_by_Doc
{            
    using System.Text;

    internal class Program
    {
        class Test
        {
            public static void Main()
            {
                string[] arr = new string[10];

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"輸入第{i + 1}組字串： ");
                    arr[i] = Console.ReadLine();
                                                            
                    if (Array.IndexOf(arr, arr[i], 0, i) >= 0)
                    // IndexOf(Array, Object, startIndex, count)
                    {
                        Console.WriteLine("輸入過");
                    }
                    else
                    {
                        Console.WriteLine("沒出現過");
                    }
                }
                Console.ReadKey();

            }
        }
    }
    
}