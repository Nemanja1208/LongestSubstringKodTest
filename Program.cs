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

        // Method to calculate the length of the longest substring without repeating characters
        public static int LongestUniqueSubstringLength(string s)
        {
            // Handle the case where the string is empty
            if (string.IsNullOrEmpty(s))
                return 0;

            // Dictionary to track the last seen index of each character
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0; // Tracks the maximum length of the unique substring
            int start = 0;     // Start index of the current substring window

            // Iterate through the string characters
            for (int index = 0; index < s.Length; index++)
            {
                char currentChar = s[index]; // Current character in the string

                // If the character already exists in the map and is within the current window
                if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)
                {
                    // Move the start of the window to the position after the last occurrence
                    start = charIndexMap[currentChar] + 1;
                }

                // Update the character's latest index in the dictionary
                charIndexMap[currentChar] = index;

                // Calculate the current substring length and update maxLength if greater
                maxLength = Math.Max(maxLength, index - start + 1);
            }

            // Return the maximum found length of the unique substring
            return maxLength;
        }
    }
}
