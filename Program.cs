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
            // Dictionary för att lagra den senaste indexen av varje tecken
            Dictionary<char, int> charMap = new Dictionary<char, int>();
            // Initialisera vänster pekare och den maximala längden
            int left = 0;
            int maxLength = 0;

            // Iterera genom strängen med höger pekare
            for (int right = 0; right < s.Length; right++)
            {
                // Om tecknet redan finns i dictionaryn och dess index är inom det aktuella fönstret
                if (charMap.ContainsKey(s[right]) && charMap[s[right]] >= left)
                {
                    // Flytta vänster pekare till en position efter den sista förekomsten av det upprepade tecknet
                    left = charMap[s[right]] + 1;
                }

                // Uppdatera den senaste indexen för tecknet
                charMap[s[right]] = right;

                // Beräkna längden på det aktuella fönstret och uppdatera maxlängden
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
        //-----------------------------------------------------
    }
}
