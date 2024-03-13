using System.Text;

namespace Problems;
public class E1768_MergeStringsAlternately
{
    public static string MergeAlternately(string word1, string word2)
    {
        StringBuilder stringBuilder = new();
        (int, string) biggestWord = word1.Length > word2.Length ? (word1.Length - 1, word1) : (word2.Length - 1, word2);
        (int, string) smallestWord = word1.Length < word2.Length ? (word1.Length - 1, word1) : (word2.Length - 1, word2);
        var diff = biggestWord.Item1 - smallestWord.Item1;

        for (int i = 0; i <= biggestWord.Item1; i++)
        {
            if (i > smallestWord.Item1)
            {
                for (int j = i; j < i + diff; j++)
                {
                    stringBuilder.Append(biggestWord.Item2[j]);
                }
                break;
            }
            stringBuilder.Append(word1[i]);
            stringBuilder.Append(word2[i]);
        }

        return stringBuilder.ToString();
    }
}
