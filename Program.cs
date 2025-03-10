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
            if (s.Length == 0) return 0; // Om strängen är tom, returnera 0

            List<char> currentSubstring = new List<char>();
            int maxLength = 0;

            foreach (char c in s)
            {
                if (currentSubstring.Contains(c)) // Om tecknet redan finns, ta bort fram tills det inte gör det
                {
                    currentSubstring.RemoveRange(0, currentSubstring.IndexOf(c) + 1);
                }

                currentSubstring.Add(c); // Lägg till tecknet i listan
                maxLength = Math.Max(maxLength, currentSubstring.Count); // Uppdatera maxlängden
            }

            return maxLength;
        }
        //-----------------------------------------------------
    }
}
