using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_LINQ
{
    static class Program
    {
        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> substringwords = words.FindAll(q => q.Contains("th"));
            foreach (var item in substringwords)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
       
    }
    static  class Term
    {
        static public string tag = "th";
    }
}
