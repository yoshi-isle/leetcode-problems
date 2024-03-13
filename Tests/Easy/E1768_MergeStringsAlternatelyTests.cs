using static Problems.E1768_MergeStringsAlternately;
namespace Tests;

public class E1768_MergeStringsAlternatelyTests
{
    [Theory]
    [InlineData("abc", "123", "a1b2c3")]
    public void Valid(string word1, string word2, string expected)
    {
        Assert.Equal(expected, MergeAlternately(word1, word2));
    }
}
