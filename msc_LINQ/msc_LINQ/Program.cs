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
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            ReturnCopyListMinusDups(names);
            Console.ReadLine();
            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };
            AverageGradeFromList(classGrades);
            string letters = "Terrill";
            AlphaOrderedStringFrequency(letters);
            Console.WriteLine("Press Any key to Exit");
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
        static void ReturnCopyListMinusDups(List<string> items)
        {

            var copyList = items.Distinct();
            foreach (var item in copyList)
            {
                Console.WriteLine(item);
            }

        }
        static void AverageGradeFromList(List<string> classGrades)
        {

            List<double> vs = new List<double>();
            foreach (var item in classGrades)
            {
                var intarray = item.Split(',').Select(x => Convert.ToInt32(x)).OrderBy(x => x).Skip(1).Average();
                vs.Add(intarray);
            }
            Console.WriteLine(vs.Average());
        }
        static void AlphaOrderedStringFrequency(string letters)
        {

            var count = letters.GroupBy(c => c).OrderBy(c => c.Key.ToString().ToLower()).ToArray();
            foreach (var item in count)
            {
                Console.WriteLine("Letter value: {0} Letter Frequency{1}  ", item.Key.ToString().ToUpper(), item.Count());
            }



        }
    }

}
