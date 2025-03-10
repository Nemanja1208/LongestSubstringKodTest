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
            // This dictionary will map each character to the last index at which it appeared.
            Dictionary<char, int> lastSeenIndices = new Dictionary<char, int>();

            // We'll keep track of the maximum length of any substring
            // we've encountered that doesn't contain repeated characters.
            int maxLength = 0;

            // 'startIndex' represents the left boundary of our current substring (the sliding window).
            int startIndex = 0;

            // We iterate through the string using 'i' as the right boundary of the sliding window.
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                // If the current character has been seen before AND
                // its last seen position is within the current sliding window
                // (i.e., >= startIndex), we need to move 'startIndex' forward
                // so we don't include the repeated character in our substring.
                if (lastSeenIndices.ContainsKey(currentChar) && lastSeenIndices[currentChar] >= startIndex)
                {
                    // Move 'startIndex' to one position after the previous occurrence of 'currentChar'.
                    // This effectively "skips over" the old repeated character, ensuring our new window is distinct.
                    startIndex = lastSeenIndices[currentChar] + 1;
                }

                // Update or add the current character's last seen position to the current index 'i'.
                lastSeenIndices[currentChar] = i;

                // The size of our current non-repeating substring is (i - startIndex + 1).
                int currentWindowSize = i - startIndex + 1;

                // If this current window is larger than any we've seen before, update 'maxLength'.
                if (currentWindowSize > maxLength)
                {
                    maxLength = currentWindowSize;
                }
            }

            // After processing all characters, 'maxLength' holds the length of the longest
            // substring with unique (non-repeating) characters.
            return maxLength;
        }

    }
}
