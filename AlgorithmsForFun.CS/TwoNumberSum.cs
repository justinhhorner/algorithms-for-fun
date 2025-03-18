namespace AlgorithmsForFun.CS;

public partial class Algorithms
{
    /// <summary>
    /// O(n) solution with O(n) space that maintains a dictionary of calculated diffs to find the sum.
    /// </summary>
    /// <param name="array">A non-empty array of distinct integers</param>
    /// <param name="targetSum">The target sum to locate</param>
    /// <returns>An array containing the two numbers that equal the target sum</returns>
    public static int[] TwoNumberSum(int[] array, int targetSum)
    {
        var prevDiffs = new Dictionary<int, bool>();
        for (var i = 0; i < array.Length; i++)
        {
            var diff = targetSum - array[i];
            if (prevDiffs.ContainsKey(array[i]))
            {
                return [array[i], diff];
            }

            prevDiffs.Add(diff, true);
        }

        return [];
    }

    /// <summary>
    /// O(nLog(n)) with O(1) space solution that sorts the input array before finding target sum elements
    /// find the sum.
    /// </summary>
    /// <param name="array">A non-empty array of distinct integers</param>
    /// <param name="targetSum">The target sum to locate</param>
    /// <returns>An array containing the two numbers that equal the target sum</returns>
    public static int[] TwoNumberSumSorted(int[] array, int targetSum)
    {
        Array.Sort(array);
        var leftIndex = 0;
        var rightIndex = array.Length - 1;

        while (leftIndex < rightIndex)
        {
            var sum = array[leftIndex] + array[rightIndex];
            if (sum == targetSum)
                return [array[leftIndex], array[rightIndex]];
            
            if (sum < targetSum)
                leftIndex++;
            else
                rightIndex--;
        }

        return [];
    }
}