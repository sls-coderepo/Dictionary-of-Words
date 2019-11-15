using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Excited", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            wordsAndDefinitions.Add("Happy", "feeling or showing pleasure or contentment.");

            /*
            Use square brackets to get the definition of two of the
            words and then output them to the console
            */

            string word1 = wordsAndDefinitions["Awesome"];
            Console.WriteLine(word1);

            string word2 = wordsAndDefinitions["Excited"];
            Console.WriteLine(word2);

            foreach (var key in wordsAndDefinitions.Keys)
            {
                Console.WriteLine(key);
            }

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                The definition of (WORD) is (DEFINITION)
                The definition of (WORD) is (DEFINITION)
                The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

        }

    }
}