using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsHexaCode("#f08080"));
            //Console.WriteLine(CalculateAverageWord("CPP Exercises. - $"));
            //Console.WriteLine(CalculateAverageWord("C# syntax is highly expressive, yet it is also simple and easy to learn."));


            //Console.WriteLine(IsPalindrome("amamd"));
            //Console.WriteLine(IsPalindrome("pamamd"));

        }

        //Q1
        static bool IsHexaCode(string input)
        {
            return Regex.IsMatch(input, @"[#][A-Fa-f0-9]{6}\b");
        }

        //Q2
        static double CalculateAverageWord(string input)
        {
            int lettersLenght = (Regex.Replace(input, @"[^A-Za-z]", "").Length);

            int countWords = Regex.Split(input , @"\W+")
                   .Count(x => !string.IsNullOrWhiteSpace(x));

            return Math.Round((double)lettersLenght / countWords, 2) ;
        }

        //Q3
        static bool IsPalindrome(string input)
        {
            string reversed = string.Join("", Regex.Matches(input, @"\w").Reverse());
            return string.Equals(input, reversed);
        }

        //Q4
    

        //Q6
        public static int RepeatedCountSentence(string sentence)
        {

            string[] words = Regex.Split(sentence, @"\W+");

            var count = words.GroupBy(x => x).Count(x => x.Count() > 1);

            return count;
        }

        //Q7
        public static bool IsVaildCurrency(string currency)
        {

            return Regex.IsMatch(currency, @"^[\d,\d]+[\p{Sc}]");

        }

        //Q8
        public static string StripWord(string word)
        {
            return Regex.Replace(word, @"[^A-Za-z]", "");
        }

        //Q9
        public static string FindWord(string sentence)
        {
            return Regex.IsMatch(sentence, "[C#]+") ? "C# document found." : "Sorry no C# document!";
        }


    }
}
