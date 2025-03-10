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

                Dictionary<char, int> charIndex = new Dictionary<char, int>(); // Sparar tecknens senaste position
                int left = 0, maxLength = 0;

                for (int right = 0; right < s.Length; right++)
                {
                    if (charIndex.ContainsKey(s[right]) && charIndex[s[right]] >= left)
                    {
                        left = charIndex[s[right]] + 1;  // Flytta left förbi upprepat tecken
                    }

                    charIndex[s[right]] = right;  // Uppdatera senaste index för tecknet
                    maxLength = Math.Max(maxLength, right - left + 1);  // Uppdatera max längd
                }

                return maxLength;
        }

            static void Main()
            {
                Console.WriteLine(LongestUniqueSubstringLength("abcabcbb")); // Output: 3
                Console.WriteLine(LongestUniqueSubstringLength("bbbb"));     // Output: 1
                Console.WriteLine(LongestUniqueSubstringLength("pwwkew"));   // Output: 3
                Console.WriteLine(LongestUniqueSubstringLength("AbCa"));     // Output: 4
                Console.WriteLine(LongestUniqueSubstringLength(""));         // Output: 0
                Console.WriteLine(LongestUniqueSubstringLength("abc def!")); // Output: 8
                Console.WriteLine(LongestUniqueSubstringLength("dvdf"));     // Output: 3
                Console.WriteLine(LongestUniqueSubstringLength("Hello, World!")); // Output: 8
            }
    }

}
