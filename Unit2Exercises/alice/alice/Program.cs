using System;

namespace alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            aliceSentence = aliceSentence.ToLower();
            Console.WriteLine("Please enter a search term");
            string userInput1 = Console.ReadLine();
            userInput1 = userInput1.ToLower();
            Console.WriteLine(aliceSentence.Contains(userInput1));
            string aliceSentence2 = aliceSentence.Remove((aliceSentence.IndexOf(userInput1)), (userInput1.Length));
            //Console.WriteLine(aliceSentence.IndexOf(userInput1));
            Console.WriteLine(aliceSentence2);
            
           
            
            
               
        }
            

    }
}

