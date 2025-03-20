namespace AlgorithmsForFun.CS;

public partial class Algorithms
{
    /// <summary>
    /// O(n) solution that tracks with array and sequence index positions
    /// </summary>
    /// <param name="array">A non-empty array of integers</param>
    /// <param name="sequence">A non-empty array of integers</param>
    /// <returns>True if sequence is a subsequence of the array. Otherwise, false</returns>
    public static bool IsValidSubsequence(int[] array, int[] sequence)
    {
        var arrayIndex = 0;
        var sequenceIndex = 0;
        
        while (arrayIndex < array.Length && sequenceIndex < sequence.Length)
        {
            if (array[arrayIndex] == sequence[sequenceIndex])
            {
               sequenceIndex++; 
            }
            
            arrayIndex++;
        }
        
        return sequenceIndex == sequence.Length;
    }
}