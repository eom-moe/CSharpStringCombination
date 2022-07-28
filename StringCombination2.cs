using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> unWords = new Dictionary<int, string>();
            Dictionary<int, string> preWords = new Dictionary<int, string>();

            preWords.Add(1, null);
            preWords.Add(2, "");

            unWords.Add(1, "a");
            unWords.Add(2, "b");

            string combination = getStringCombination(unWords.Values.ToList(), preWords.Values.ToList());
            Console.WriteLine(combination);
        }
        static string getStringCombination(List<string> unWords, List<string> preWords)
        {
          StringBuilder unStringCat = new StringBuilder();
          string combination = null;
          preWords.Add("");
          for (int rowIndex = 0; rowIndex < Math.Max(unWords.Count, preWords.Count); rowIndex++) {
            string pre = "";
            if (rowIndex < preWords.Count) {
              Console.WriteLine("preWord: " + preWords[rowIndex]);
              pre = preWords[rowIndex];
            }
            string un = "";
            if (rowIndex < unWords.Count) {
              Console.WriteLine("unWord: " + unWords[rowIndex]);
              un = unWords[rowIndex];
            }
            string stringCombination = pre + un;
            unStringCat.Append(stringCombination);
          }
          combination = unStringCat.ToString();

          return combination;
        }
    }
