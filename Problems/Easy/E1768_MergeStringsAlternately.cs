using System.Text;

namespace Problems;
public class E1768_MergeStringsAlternately
{
    /// <summary>
    /// https://leetcode.com/problems/merge-strings-alternately/description/
    /// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
    /// If a string is longer than the other, append the additional letters onto the end of the merged string.
    /// Return the merged string.
    /// </summary>
    public static string MergeAlternately(string word1, string word2)
    {
        StringBuilder result = new();
        (string word, int index) upper = word1.Length > word2.Length ? (word1, word1.Length - 1) : (word2, word2.Length - 1);
        (string word, int index) lower = word1.Length > word2.Length ? (word2, word2.Length - 1) : (word1, word1.Length - 1);

        for (int i = 0; i <= upper.index; i++)
        {
            if (i <= lower.index)
            {
                result.Append(word1[i]);
                result.Append(word2[i]);
                continue;
            }
            int charsRemaining = upper.index - lower.index;
            for (int n = i; n < i + charsRemaining; n++)
            {
                result.Append(upper.word[n]);
            }
            break;
        }

        return result.ToString();
    }
}
