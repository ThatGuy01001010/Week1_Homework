using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamlet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText(@"Hamlet.txt"));
            Console.ReadLine();
        }
    }
}

/*

 * var dict = new dictionary<string, int>;                              // dictionary of words and occurrences
 * dictionary<string, int> wordCountDict;
 * 
 * Open "Hamlet.txt"                                          // Open an read the text file to a streng,
 *     string Whole = "Hamlet.txt"                            // then split it by line
 *     string[] lines = Whole.split('\n')
 * 
 * foreach (var line in Whole)                                //for each line array, split into words by spaces
 * {
 *     string[] splitLines = Whole.split(' ');                // now have an array of arrays (lines, words)
 * }
 * 
 * foreach (var word in splitLine)                             // for each word in the split lines,
 * {
 *     if (dict.ContainsKey(word.ToLower()))                   // if the dict contains the lower case key "word"
 *     {
 *         dict[word.ToLower()] += 1                           // increase the int at words location by 1
 *     }
 *     else
 *     {
 *         dict.Add(word.ToLower(), 1);                        // otherwise, add the word in lower case to the dictionary with an int of 1
 *     }
 * }
 * 
 * list<string> sortedWords = dict.Keys.ToList().Sort()         // sort the words alphabetically
 * 
 * foreach (KeyValuePair<string, int> item in dict.OrderBy(Key => Key.Value))       //filling the dict to sort by word count
 * {
 *      wordCountDict.Add(item, item.value);
 * }
 * 
 * Console.WriteLine("Would you like to see an alphabetical list of words or words by occurrence?");
 * Console.WriteLine("1: Alphabetical   2: Occurrence   3: Quit");
 * int choice = 0;
 * do
 * {
 *      Console.ReadLine(choice);
 *      
 *      if (choice == 1)
 *      {
 *          for (int i = 0; i < sortedWords.Count(); i++)
 *          {
 *              Console.WriteLine(sortedWords[i]);
 *          }
 *      }
 *      else if (choice == 2)
 *      {
 *          foreach (KeyValuePair<string, int> myPair in wordCountDict)
 *          {
 *              Console.WriteLine("{0}: {1}", myPair.Key, myPair.Value);
 *          } 
 *      }
 *      else
 *      {
 *          return 0;
 *      }
 * } while (choice < 1 || choice > 3);


 
 
 
*/