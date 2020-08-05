using System;
using System.Linq;
using System.Collections.Generic;


namespace BensChallenge
{
    class Program
    {
      
        string[] sdata;
        char[] delimiter = new char[] {' ', ',','.','?','!'};
       
   
        public void Split(string userInput, List<string> dataConverted)
        {
             sdata = userInput.Split(delimiter, userInput.Length);
             foreach(var word in sdata)
             {
                dataConverted.Add(word);
             }
          
        }
        static void Main(string[] args)
        {
            List<string> dataConverted = new List<string> { };
            Console.WriteLine("Write a phrase.");
            string userInput = Console.ReadLine();
            var input = new Program();
            input.Split(userInput, dataConverted);
            var convert = new Program();
            convert.printsOccurences(dataConverted);
        }

        public void printsOccurences(List<String> dataConverted)
        {

            
                var Sorting =
                from countedWord in dataConverted
                group countedWord by countedWord into x
                select new { Word = x.Key, Count = x.Count() };
                foreach (var countedWord in Sorting)
                {
                Console.WriteLine($"{countedWord.Word}: {countedWord.Count}");
                }
                
        }


    }
}



