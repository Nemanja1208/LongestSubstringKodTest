using System;
using System.Collections.Generic;

namespace LongestSubstringKodTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] testStrings = new string[]
            {
                "abcabcbb",      // 3
                "bbbb",          // 1
                "pwwkew",        // 3
                "AbCa",          // 4
                "",              // 0
                "abc def!",      // 8
                "Hello, World!", // 8
                "abcdeafgh",     // 8
                "abcddefgg",     // 4
                " ",             // 1
                "   ",           // 1
                "a b c d e"      // 3
            };

            foreach (var s in testStrings)
            {
                Console.WriteLine($"Input: \"{s}\" -> {LongestUniqueSubstringLength(s)}");
            }
        }

        public static int LongestUniqueSubstringLength(string s)
        {
            var set = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                    set.Remove(s[left++]);

                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
