using System;

namespace LongestSubstringKodTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Testfall
            string[] testStrings = new string[]
            {
                "abcabcbb", "bbbb", "pwwkew", "AbCa", "", "abc def!",
                "Hello, World!", "abcdeafgh", "abcddefgg", " ", "   ", "a b c d e"
            };

            Console.WriteLine("=== Longest Unique Substring Challenge ===\n");

            foreach (var s in testStrings)
            {
                int result = LongestUniqueSubstringLength(s);
                Console.WriteLine($"Input: \"{s}\" -> Longest unique substring length: {result}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static int LongestUniqueSubstringLength(string s)
        {
            int maxLength = 0; // Håller koll på längsta delsträngen
            int count = 0; // Räknar tecken i nuvarande delsträng

            // Loopar igenom varje tecken i strängen
            for (int i = 0; i < s.Length; i++)
            {
                count = 0; // Nollställ räkningen för varje startposition

                // Kollar resten av strängen från position `i`
                for (int j = i; j < s.Length; j++)
                {
                    // Om tecknet redan finns i den undersökta delsträngen, avbryt
                    if (s.Substring(i, count).Contains(s[j]))
                        break;

                    count++; // Öka längden på unika delsträngen
                }

                // Uppdatera max längden om vi hittat en längre unika sekvens
                if (count > maxLength)
                    maxLength = count;
            }

            return maxLength;
        }
    }
}
