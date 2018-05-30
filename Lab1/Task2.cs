using System;
using System.Text;

namespace Lab1
{
    public static class Task2
    {
        static string CapitalizeSentences(string input)
        {
            char[] EndOfSentence = { '.', '!', '?' };
            StringBuilder result = new StringBuilder();
            result.Append(input);
            for (int i = 0; i < input.Length; i++)
            {
                int index = input.IndexOfAny(EndOfSentence, i);
                if (index > 0)
                {
                    while (!(Char.IsLetter(input[index])) && index < input.Length - 1)
                    {
                        index++;
                    }
                    result[index] = char.ToUpper(result[index]);
                    i = index;
                }
            }
            return result.ToString();
        }

        static public void Demo()
        {
            Console.WriteLine("\nText:");
            string input = Console.ReadLine();
            Console.WriteLine(CapitalizeSentences(input));
        }
    }
}
