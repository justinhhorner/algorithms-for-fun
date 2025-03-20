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
    public void TwoNumberSum(int[] input, int targetSum, int[] expectedResult)
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
    public void TwoNumberSum_Sorted(int[] input, int targetSum, int[] expectedResult)
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
    public void ValidateSubsequence(int[] input, int[] sequence, bool expectedResult = true)
    {
        var result = Algorithms.IsValidSubsequence(input, sequence);

        Assert.Equal(expectedResult, result);
    }
}