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
                // int för resultat fint
                int result = LongestUniqueSubstringLength(s);

                //console för visa de display så bra jobbat
                Console.WriteLine($"Input: \"{s}\" -> Longest unique substring length: {result}");
            }
            //console för visa de display så bra jobbat text för att avsluta
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static int LongestUniqueSubstringLength(string s)
        {
            int maxLength = 0; // Bra att du Håller koll på längsta delsträngen
            int count = 0; // Detta är bra här räknar man nuvarande delsträng

            // du har lagt till Loopar  för att igenom för varje tecken i strängen
            for (int i = 0; i < s.Length; i++)
            {
                count = 0; // bra att  du Nollställ räkningen för varje startposition

                // ser bra ut att du Kollar resten av strängen från position `i`
                for (int j = i; j < s.Length; j++)
                {
                    // Om tecknet redan finns i den undersökta delsträngen, avbryt
                    if (s.Substring(i, count).Contains(s[j]))
                        break;

                    count++; // duktig mario som checkar att Öka längden på unika delsträngen
                }

                // Uppdatera max längden om vi hittat en längre unika sekvens
                if (count > maxLength)
                    maxLength = count;
            }
            // här retunerara vi max lengd
            return maxLength;
        }
    }
}
