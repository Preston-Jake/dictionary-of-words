using System;
using System.Collections.Generic;
namespace c__dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            var wordsAndDefinitions = new Dictionary<string, string>(){
                {"Awesome", "The feeling of students when they are learning C#"}
            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Flair", "a skill or instinctive ability to appreciate or make good use of something");
            wordsAndDefinitions.Add("Metathesis", "a change of place or condition");
            wordsAndDefinitions.Add("Churlish", "difficult to work with or deal with");
            wordsAndDefinitions.Add("Sedulous", "diligent in application or pursuit");
            wordsAndDefinitions.Add("Plummy", "full of plums");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Plummy"]);
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
