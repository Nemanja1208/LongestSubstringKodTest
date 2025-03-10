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
            // If the string is empty, return 0 immediately
            if (string.IsNullOrEmpty(s)) return 0;

            // Dictionary to keep track of the last seen index of each character
            Dictionary<char, int> charIndex = new Dictionary<char, int>();

            int maxLength = 0; // Stores the length of the longest found substring
            int left = 0;      // The starting position of our "window"

            // Iterate through each character in the string
            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right]; // The character we're currently checking

                // If the character is already in the dictionary AND within the current window
                if (charIndex.ContainsKey(currentChar) && charIndex[currentChar] >= left)
                {
                    // Move the left boundary past the last occurrence of the duplicate
                    left = charIndex[currentChar] + 1;
                }

                // Update the character's last seen position
                charIndex[currentChar] = right;

                // Calculate the current substring length and update maxLength if it's the longest so far
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            // Return the length of the longest unique substring
            return maxLength;
        }
        //-----------------------------------------------------
    }
}
