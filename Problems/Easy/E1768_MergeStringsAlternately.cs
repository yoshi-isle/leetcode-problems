namespace Problems;

public class E1768_MergeStringsAlternately
{
    public static string MergeAlternately(string word1, string word2)
    {
        string mergedString = string.Empty;

        var upperBounds = Math.Max(word1.Length, word2.Length) - 1;
        var lowerBounds = Math.Min(word1.Length, word2.Length) - 1;
        string longestWord = word1.Length > word2.Length ? word1 : word2;
        var diff = upperBounds - lowerBounds;

        for (int i = 0; i <= upperBounds; i++)
        {
            if (i > lowerBounds)
            {
                for (int j = i; j < i + diff; j++)
                {

                    mergedString += longestWord[j];
                }
                break;
            }
            mergedString += word1[i];
            mergedString += word2[i];
        }

        return mergedString;
    }
}
