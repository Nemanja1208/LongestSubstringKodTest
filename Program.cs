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
            if (string.IsNullOrEmpty(s)) return 0; //  4th array if its empty array then it returns 0;

            List<char> windowIndex = new List<char>(); // The Chars. 

            int maxLength = 0; // Maxiumum length of chars.

            foreach (var c in s)
            {
                while (windowIndex.Contains(c)) // If it contains same Character
                {
                 windowIndex.RemoveAt(0); // Removes same repeated Char
                }

                windowIndex.Add(c); // adds then a character to the string until it founds a dupplicate.

              //  maxLength = Math.Max(maxLength, windowIndex.Count); // Accounts max length of chars. 
                
            }

            return maxLength;
                   
            // Currently returns -1 so you know it's not implemented yet
            // Replace this logic with your solution
            
        }
        //-----------------------------------------------------
    }
}
