namespace AlgorithmsForFun.CS;

public partial class Algorithms 
{
   /// <summary>
   ///  O(n) solution using left/right pointers to calculate abs values and place squared values from right to left
   /// </summary>
   /// <param name="array">A non-empty array of integers sorted in ascending order</param>
   /// <returns>Array of the same length as `array` with squares of original integers in ascending order</returns>
   public static int[] SortedSquareArray(int[] array)
   {
      var squaredArray = new int[array.Length];
      
      var leftIndex = 0;
      var rightIndex = array.Length - 1;
      var insertIndex = rightIndex;
      
      while (rightIndex >= leftIndex)
      {
         var leftValue = Math.Abs(array[leftIndex]);
         var rightValue = Math.Abs(array[rightIndex]);

         if (rightValue > leftValue)
         {
            squaredArray[insertIndex] = rightValue * rightValue;
            rightIndex--;
         }
         else
         {
            squaredArray[insertIndex] = leftValue * leftValue;
            leftIndex++;
         }
         
         insertIndex--;
      }

      return squaredArray;
   }
}