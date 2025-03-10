using System;
using System.Collections.Generic;

namespace LongestSubstringKodTest
{
    public class Program
    {
        // Programmet startar här
        static void Main(string[] args)
        {
            // Skapar en array med teststrängar som ska testas
            string[] testStrings = new string[]
            {
                "abcabcbb",      // Förväntad längd: 3 (unik substring: "abc")
                "bbbb",          // Förväntad längd: 1 (unik substring: "b")
                "pwwkew",        // Förväntad längd: 3 (unik substring: "wke")
                "AbCa",          // Förväntad längd: 4 (unik substring: "AbCa")
                "",              // Förväntad längd: 0 (ingen tecken)
                "abc def!",      // Förväntad längd: 8 (unik substring: "abc def!")
                "Hello, World!", // Förväntad längd: 8 (unik substring: "Hello, W")
                "abcdeafgh",     // Förväntad längd: 8 (unik substring: "abcdeafg")
                "abcddefgg",     // Förväntad längd: 4 (unik substring: "abcd")
                " ",             // Förväntad längd: 1 (unik substring: " ")
                "   ",           // Förväntad längd: 1 (unik substring: " ")
                "a b c d e"      // Förväntad längd: 3 (unik substring: "a b")
            };

            // Loopar igenom varje teststräng och skriver ut resultatet
            foreach (var s in testStrings)
            {
                // För varje sträng, beräkna längden på den längsta unika substringen
                // och skriv ut resultatet
                Console.WriteLine($"Input: \"{s}\" -> {LongestUniqueSubstringLength(s)}");
            }
        }

        // Metod som beräknar den längsta substringen utan upprepade tecken
        public static int LongestUniqueSubstringLength(string s)
        {
            // Skapar en HashSet för att hålla unika tecken i substringen
            var set = new HashSet<char>();

            // Variabler för vänster pekare och för att hålla koll på maxlängd
            int left = 0, maxLength = 0;

            // Loopa genom strängen med den högra pekaren (right)
            for (int right = 0; right < s.Length; right++)
            {
                // Om tecknet vid 'right' redan finns i setet, flytta vänster pekare framåt
                // tills tecknet på 'right' kan läggas till utan att skapa en upprepning
                while (set.Contains(s[right]))
                    // Ta bort tecken från vänster sida av substringen tills den är unik
                    set.Remove(s[left++]);

                // Lägg till det aktuella tecknet från 'right' till setet
                set.Add(s[right]);

                // Uppdatera maxlängden om den nuvarande längden på fönstret är längre
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            // Returnera den längsta längden på en unik substring
            return maxLength;
        }
    }
}
