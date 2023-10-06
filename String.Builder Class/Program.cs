using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Builder_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("abcabcabcabcabcabcabca" +
                "bcabcabcabc", 30);
            //Console.WriteLine($"sb = {sb}");
            //Console.WriteLine($"Type of sb is {sb.GetType()}");
            //Console.WriteLine($"Length of sb is {sb.Length}");

            //Console.WriteLine("------------------------------------");

            //sb.Append(new string[]{"qqq", "eee"});
            //Console.WriteLine($"sb = {sb}");                      // ???
            //Console.WriteLine($"Type of sb is {sb.GetType()}");
            //Console.WriteLine($"Length of sb is {sb.Length}");

            //for(int i =0;i<sb.Length;i++)
            //{
            //    Console.WriteLine(sb[i]);
            //}



            

            Console.ReadKey();
        }
    }
}
