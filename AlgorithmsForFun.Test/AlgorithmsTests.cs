using AlgorithmsForFun.CS;

namespace AlgorithmsForFun.Test;

public class AlgorithmsTests
{
    [Theory]
    [InlineData(new[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10, new[] { -1, 11 })]
    [InlineData(new[] { 4, 6 }, 10, new[] { 4, 6 })]
    [InlineData(new[] { 4, 6, 1 }, 5, new[] { 4, 1 })]
    [InlineData(new[] { 4, 6, 1, -3 }, 3, new[] { 6, -3 })]
    [InlineData(new[] { 14 }, 15, new int[] { })]
    public void TwoNumberSumTest(int[] input, int targetSum, int[] expectedResult)
    {
        var result = Algorithms.TwoNumberSum(input, targetSum);

        Assert.True(expectedResult.OrderBy(x => x).SequenceEqual(result.OrderBy(x => x)));
    }

    [Theory]
    [InlineData(new[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10, new[] { -1, 11 })]
    [InlineData(new[] { 4, 6 }, 10, new[] { 4, 6 })]
    [InlineData(new[] { 4, 6, 1 }, 5, new[] { 4, 1 })]
    [InlineData(new[] { 4, 6, 1, -3 }, 3, new[] { 6, -3 })]
    [InlineData(new[] { 14 }, 15, new int[] { })]
    public void TwoNumberSum_SortedTest(int[] input, int targetSum, int[] expectedResult)
    {
        var result = Algorithms.TwoNumberSumSorted(input, targetSum);

        Assert.True(expectedResult.OrderBy(x => x).SequenceEqual(result.OrderBy(x => x)));
    }

    [Theory]
    [InlineData(new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 1, 6, -1, 10 })]
    [InlineData(new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 5, 1, 22, 25, 6, -1, 8, 10 })]
    [InlineData(new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 5, 1, 22, 6, -1, 8, 10 })]
    [InlineData(new[] { 5, 1, 22, 25, 6, -1, 8, 10 }, new[] { 25 })]
    [InlineData(new[] {1, 1, 1, 1, 1 }, new[] { 1, 1, 1})]
    [InlineData(new[] {1, 1, 6, 1 }, new[] { 1, 1, 1, 6 }, false)]
    [InlineData(new[] {5, 1, 22, 25, 6, -1, 8, 10}, new[] {5, 1, 22, 23, 6, -1, 8, 10}, false)]
    public void ValidateSubsequenceTest(int[] input, int[] sequence, bool expectedResult = true)
    {
        var result = Algorithms.IsValidSubsequence(input, sequence);

        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new [] { -2, -1 }, new [] { 1, 4 })]
    [InlineData(new [] { 1 }, new [] { 1 })]
    [InlineData(new [] { 0 }, new [] { 0 })]
    [InlineData(new [] { 1, 2 }, new [] { 1, 4 })]
    [InlineData(new [] { -5, -4, -3, -2, -1 }, new [] { 1, 4, 9, 16, 25 })]
    [InlineData(new [] { 1, 2, 3, 5, 6, 8, 9}, new [] { 1, 4, 9, 25, 36, 64, 81})]
    public void SortedSquaredArrayTest(int[] input, int[] expectedResult)
    {
        var result = Algorithms.SortedSquareArray(input);
        
        Assert.True(expectedResult.SequenceEqual(result.OrderBy(x => x)));
    }
}