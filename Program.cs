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

            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                int result = LongestUniqueSubstringLength(input);
                Console.WriteLine($"Longest unique character sequence length: {result}");
            }
            // TODO: Implement this method
            //-----------------------------------------------------
            static int LongestUniqueSubstringLength(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: Input cannot be empty.");
                return 0;
            }

            HashSet<char> seenChars = new HashSet<char>();
            int maxLength = 0, left = 0;

            for (int right = 0; right < input.Length; right++)
            {
                while (seenChars.Contains(input[right]))
                {
                    seenChars.Remove(input[left]);
                    left++;
                }

                seenChars.Add(input[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
        //-----------------------------------------------------
    }
}
}
