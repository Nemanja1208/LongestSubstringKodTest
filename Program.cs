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
                int result = LongestUniqueSubstringLength(s); // Call method with string 's'

                Console.WriteLine($"Input: \"{s}\" -> Longest unique substring length: {result}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Method to find the longest unique substring length
        //-----------------------------------------------------
        public static int LongestUniqueSubstringLength(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int maxLength = 0;
            List<char> currentSubstring = new List<char>(); // To track unique characters in the current substring

            for (int end = 0; end < input.Length; end++)
            {
                // If the character is already in the list, remove characters from the start until it's unique
                while (currentSubstring.Contains(input[end]))
                {
                    currentSubstring.RemoveAt(0); // Remove the first character to make space
                }

                // Add the current character to the list
                currentSubstring.Add(input[end]);

                // Update maxLength if the current substring is longer
                maxLength = Math.Max(maxLength, currentSubstring.Count);
            }

            return maxLength;
        }
    }
}
