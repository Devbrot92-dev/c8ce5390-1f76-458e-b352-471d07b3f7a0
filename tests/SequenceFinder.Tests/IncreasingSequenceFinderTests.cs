using SequenceFinder;

namespace SequenceFinder.Tests;

public class IncreasingSequenceFinderTests
{
    [Fact]
    public void Find_ReturnsLongestIncreasingSequence()
    {
        string input = "6 1 5 9 2";

        string result = IncreasingSequenceFinder.Find(input);

        Assert.Equal("1 5 9", result);

    }

    [Fact]
    public void Find_ReturnsEarliestSequence_WhenLengthsAreEqual()
    {
        string input = "6 2 4 6 1 5 9 2";

        string result = IncreasingSequenceFinder.Find(input);

        Assert.Equal("2 4 6", result);
    }

    [Fact]
    public void Find_ReturnsSingleNumber_WhenInputContainsOneNumber()
    {
        string input = "7";

        string result = IncreasingSequenceFinder.Find(input);

        Assert.Equal("7", result);
    }

    [Fact]
    public void Find_ReturnsFirstNumber_WhenSequenceIsStrictlyDecreasing()
    {
        string input = "9 7 5 3";

        string result = IncreasingSequenceFinder.Find(input);

        Assert.Equal("9", result);
    }

    [Fact]
    public void Find_ReturnsEmptyString_WhenInputIsEmpty()
    {
        string result = IncreasingSequenceFinder.Find(string.Empty);

        Assert.Equal(string.Empty, result);
    }

    [Theory]
    [InlineData("6 2 4 6 1 5 9 2", "2 4 6")]
    [InlineData("6 2 4 3 1 5 9", "1 5 9")]
    public void Find_MatchesProvidedExamples(string input, string expected)
    {
        string result = IncreasingSequenceFinder.Find(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Find_ThrowsFormatException_WhenInputContainsInvalidValue()
    {
        Assert.Throws<FormatException>(
            () => IncreasingSequenceFinder.Find("6 1 5 . 9"));
    }

    [Fact]
    public void Find_HandlesDifferentWhitespace()
    {
        string result =
            IncreasingSequenceFinder.Find("6\t1  5\n9 2");

        Assert.Equal("1 5 9", result);
    }


}
