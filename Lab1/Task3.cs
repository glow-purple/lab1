using System;
using System.Text.RegularExpressions;

namespace Lab1
{
    public static class Task3
    {
        public static MatchCollection FindWord(string text, string search)
        {
            MatchCollection found = Regex.Matches(text, @"(?i)\b" + search + @"\b");
            return found;
        }
        public static void ShowMatchesCount(string text, string search)
        {
            MatchCollection matches = FindWord(text, search);
            Console.WriteLine($"{search}: {matches.Count} match(es) found");
        }
        public static void Demo()
        {
            string text = "\nSur la musique, on va on vient, \n" +
                "On s'éloigne et on revient \n" +
                "Puis tu t'élances et je te tiens \n" +
                "Je te retiens du bout des doigts \n" +
                "Pour te ramener contre moi ";
            Console.WriteLine(text);
            Console.WriteLine("\nSearch:");
            string search = Console.ReadLine();
            ShowMatchesCount(text, search);
        }
    }
}
