using static Problems.E1768_MergeStringsAlternately;
namespace Tests;

public class E1768_MergeStringsAlternatelyTests
{
    [Theory]
    [InlineData("abc", "123", "a1b2c3")]
    [InlineData("abcdef", "123", "a1b2c3def")]
    [InlineData("abc", "123456", "a1b2c3456")]
    [InlineData("", "", "")]
    [InlineData("aaaaa", "", "aaaaa")]
    [InlineData("", "bbbbb", "bbbbb")]
    public void Valid(string word1, string word2, string expected)
    {
        Assert.Equal(expected, MergeAlternately(word1, word2));
    }
}
