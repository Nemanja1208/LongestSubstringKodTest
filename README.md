# 🔎 Longest Substring Without Repeating Characters

Welcome to the **Longest Substring Without Repeating Characters** challenge!  
This repository contains a coding challenge for returning the length of the longest substring in which all characters are distinct. Feel free to clone, fork, or submit pull requests to improve the project. Happy coding! ✨

---
## About the Challenge

🔹 **Goal:**  
Given a string `s`, determine the length of the **longest substring** that contains **no repeating characters**.

---

## Requirements

1. **Empty String**  
   - If the input string is empty, the method should return `0`.  
     <br>📝 *Example:* `""` ⇒ `0`

2. **Case Sensitivity**  
   - Uppercase and lowercase letters are considered **different** characters.  
     <br>📝 *Example:* `"Aa"` has length `2` because `'A'` ≠ `'a'`.

3. **Spaces, Punctuation, Digits**  
   - Treat all non-alphabetic characters like any other character.  
     <br>📝 *Example:* `"abc!d e"` where `!` and spaces are just like letters.

4. **No Duplicates**  
   - Once a character repeats, it ends the current substring for the “no-repeat” condition.

---

## Examples

Below is a table of inputs, expected outputs, and brief explanations. 🎉

| Input            | Output | Explanation                                                              |
|------------------|--------|--------------------------------------------------------------------------|
| `"abcabcbb"`     | 3      | Longest substring is `"abc"`                                             |
| `"bbbb"`         | 1      | Longest substring is `"b"`                                               |
| `"pwwkew"`       | 3      | Longest substring is `"wke"`                                             |
| `"AbCa"`         | 4      | `"AbCa"` is valid (uppercase `A` != lowercase `a`)                       |
| `""` (empty)     | 0      | No characters ⇒ length is `0`                                           |
| `"abc def!"`     | 8      | Could be `"abc def!"` (assuming no repeated punctuation or letters)      |
| `"dvdf"`         | 3      | `"vdf"`                                                                  |
| `"Hello, World!"`| 8      | Substring `", World!"`                                                   |

---

## Getting Started

1. **Clone the Repo**  
   ```bash
   git clone https://github.com/YourOrg/LongestUniqueSubstringChallenge.git

2. **Create your own branch and start working**  
   ```bash
   git checkout -b "name-lastname-longestsubstring"
