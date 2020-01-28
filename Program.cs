using System;
using System.Collections;

namespace String_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************************************
            *
            * Basic Substring String Example
            *
            ***************************************/
            //string string1 = "Hello World!!!";
            //int length = string1.Length;
            //int position = string1.IndexOf(" ");
            //string firstWord, secondWord;

            //firstWord = string1.Substring(0, position);
            //secondWord = string1.Substring(position + 1, (length-1) - (position)); // This algo works because the index of " " is hard coded as var position

            //Console.WriteLine("First word: " + firstWord);
            //Console.WriteLine("Second word: " + secondWord);


            /**************************************
            *
            * Basic Substring String Example. Spliting each word in a string into a Array List
            *
            ***************************************/

            string aString = "Now is the time myFriend";
            ArrayList wordList = SplitWord(aString);

            foreach (string i in wordList)
                Console.Write(i + " ");

            Console.Write($"\nLength of wordList is {wordList.Count}");

            

        } // End Main()

        private static ArrayList SplitWord(string aString)
        {
            int position;
            string word;
            string indexSearchElement = " "; // find specific character in aString
            ArrayList wordList = new ArrayList();

            position = aString.IndexOf(indexSearchElement);

            while (position > 0)
            {
                word = aString.Substring(0, position);
                wordList.Add(word);

                aString = aString.Substring((position + 1), (aString.Length - 1) - (position));

                position = aString.IndexOf(indexSearchElement);

                if (position == -1)
                {
                    word = aString.Substring(0, aString.Length);
                    wordList.Add(word);
                }
            }

            return wordList;
        }
    }
}
