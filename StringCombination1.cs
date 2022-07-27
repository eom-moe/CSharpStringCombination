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

            preWords.Add(1, "pre1");
            preWords.Add(2, "");
            preWords.Add(3, "pre3");
            preWords.Add(4, "pre4");
            preWords.Add(5, "pre5");
            preWords.Add(6, null);

            unWords.Add(1, "un1");
            unWords.Add(2, "un2");
            unWords.Add(3, null);
            unWords.Add(4, "un4");
            Console.WriteLine(preWords.Count);
            string combination = getStringCombination(unWords.Values.ToList(), preWords.Values.ToList());
            Console.WriteLine(combination);
        }
        static string getStringCombination(List<string> unWords, List<string> preWords)
        {
          string combination = "";
          int preIndex = 0;
          int unIndex = 0;
          for (int rowIndex = 0; rowIndex < Math.Max(unWords.Count, preWords.Count); rowIndex++) {
            while (preIndex < preWords.Count && (preWords[preIndex] == null || preWords[preIndex].Count() == 0)) {
              preIndex += 1;
            }
            if (preIndex < preWords.Count) {
              combination += preWords[preIndex] + " ";
            } else {
              combination += "";
            }
            preIndex += 1;

            while (unIndex < unWords.Count && (unWords[unIndex] == null || unWords[unIndex].Count() == 0)) {
              unIndex += 1;
            }
            if (unIndex < unWords.Count) {
              combination += unWords[unIndex] + " ";
            } else {
              combination += "";
            }
            unIndex += 1;
          }
          return combination;
        }
    }
