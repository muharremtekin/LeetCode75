public class FindTheIndexOfTheFirstOccurrenceInAString
{
    // 28. Find the Index of the First Occurrence in a String
    // Easy
    // Topics
    // Companies
    // Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, 
    // or -1 if needle is not part of haystack.


    // Example 1:
    // Input: haystack = "sadbutsad", needle = "sad"
    // Output: 0
    // Explanation: "sad" occurs at index 0 and 6.
    // The first occurrence is at index 0, so we return 0.

    // Example 2:
    // Input: haystack = "leetcode", needle = "leeto"
    // Output: -1
    // Explanation: "leeto" did not occur in "leetcode", so we return -1.


    // Constraints:
    // 1 <= haystack.length, needle.length <= 104
    // haystack and needle consist of only lowercase English characters.

    public static int StrStr(string haystack, string needle)
    {

        if (needle.Length is 0) return 0;

        for (int i = 0; i < haystack.Length + 1 - needle.Length; i++)
        {
            if (haystack[i] != needle[0]) continue;

            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j]) break;

                if(j == needle.Length - 1) return i;
            }
        }

        return -1;
    }
}