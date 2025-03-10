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
            //kollar först om strängen är tom
            if (string.IsNullOrEmpty(s))
            {
                return 0; // Om strängen är tom, returnera 0
            }

            //Skapa en dictionary för att spara varje unik karaktär och dess index
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>(); 
            int maxLength = 0; //Håller reda på den längsta unika delsträngen vi hittar
            int left = 0; // Håller koll på startpositionen för aktuella delsträngen

            // Gå igenom varje tecken i strängen
            for (int right = 0; right < s.Length; right++)
            {
                if (charIndexMap.ContainsKey(s[right]))
                {
                    // Om tecknet finns, flytta left förbi senaste positionen där tecknet fanns
                    left = Math.Max(charIndexMap[s[right]] + 1, left);
                }

                // Uppdatera indexet för det aktuella tecknet
                charIndexMap[s[right]] = right;

                // Uppdatera maxlängden på den unika delsträngen
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
        //-----------------------------------------------------
    }
}
