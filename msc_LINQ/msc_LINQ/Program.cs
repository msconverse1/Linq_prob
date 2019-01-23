using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_LINQ
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            FindSubString(words);
            Console.ReadLine();
            Console.Clear();
            ReturnCopyListMinusDups();
            Console.ReadLine();
        }
       static void FindSubString(List<string> words)
        {
            string tag = "th";
            
            List<string> substringwords = words.FindAll(q => q.Contains(tag));
            foreach (var item in substringwords)
            {
                Console.WriteLine(item);
            }
        }
       static void ReturnCopyListMinusDups()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var copyList = names.Distinct();
            foreach (var item in copyList)
            {
                Console.WriteLine(item);
            }
            
        }
    }

}
