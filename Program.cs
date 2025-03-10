using System.Runtime.Serialization.Formatters;

namespace LongestSubstringKodTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Test strings and their expected results:
            string[] testStrings = new string[]
            {
                "abcabcbb",      // Repeated pattern of 'abc'                       -> 3
                "bbbb",          // All the same character                          -> 1
                "pwwkew",        // Mixed repetition with 'w' characters            -> 3
                "AbCa",          // Case sensitivity test                           -> 4
                "",              // Empty string                                    -> 0
                "abc def!",      // Includes a space and punctuation                -> 8
                "Hello, World!", // Includes punctuation and a space                -> 8
                "abcdeafgh",     // Single repeated character after a long run      -> 8
                "abcddefgg",     // Two different repeats ('d' and 'g')             -> 4
                " ",             // Single space                                    -> 1
                "   ",           // Multiple consecutive spaces                     -> 1
                "a b c d e"      // Characters separated by spaces                  -> 3
            };

            Console.WriteLine("=== Longest Unique Substring Challenge ===");
            Console.WriteLine();

            foreach (var s in testStrings)
            {
                int result = LongestUniqueSubstringLength(s); // TODO: Implement method

                Console.WriteLine($"Input: \"{s}\" -> Longest unique substring length: {result}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // TODO: Implement this method
        //-----------------------------------------------------
        public static int LongestUniqueSubstringLength(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int maxLength = 0; // håller koll på längden av den längsta unika sekvensen hittills
            int left = 0;  //pekar ut det aktuella fönstret i strängen som innehåller unika tecken

            //Dictionary används för att hålla koll på senaste index av varje tecken
            Dictionary<char, int> seenChars = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right]; //// Hämta tecknet vid positionen 'right' i strängen för att kontrollera det

                // Om tecknet redan finns i dictionaryt och är innanför aktuellt fönster
                if (seenChars.ContainsKey(currentChar) && seenChars[currentChar] >= left)
                {
                    // Flytta vänstra pekaren precis efter den förra upprepningen
                    left = seenChars[currentChar] + 1;
                }

                // Uppdatera indexet för nuvarande tecken
                seenChars[currentChar] = right;

                // Beräkna längden på nuvarande unika substring och uppdatera max om det är större
                int currentLength = right - left + 1;
                if (currentLength > maxLength)
                    maxLength = currentLength;
            }

            return maxLength;

        }
        //-----------------------------------------------------
    }
}
