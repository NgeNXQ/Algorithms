using System.Runtime.InteropServices;

namespace Algorithms
{
    internal static class RoflAlgorithms
    {
        public static int CountSumOfArray(int[] array)
        {
            if(array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");

            return CountSumOfArrayInnerRecusrion(0);

            int CountSumOfArrayInnerRecusrion(int pivot)
            {
                if (pivot == array.Length - 1)
                    return array[pivot];
                else
                    return array[pivot] + CountSumOfArrayInnerRecusrion(++pivot);
            }
        }

        public static int CountNumberOfElements(int[] array)
        {
            if (array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");

            return CountingElementsInnerRecursion(0);

            int CountingElementsInnerRecursion(int pivot)
            {
                if (pivot == array.Length)
                    return pivot;
                else
                    return CountingElementsInnerRecursion(++pivot);
            }
        }

        public static int FindLargestNumber(int[] array)
        {
            if(array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");
            else if (array.Length == 0)
                throw new System.InvalidOperationException($"{nameof(array)} has 0 elements.");

            return FindLargestNumberInnerRecursion(1, array[0]);

            int FindLargestNumberInnerRecursion(int position, int largestNumber)
            {
                if(position == array.Length)
                    return largestNumber;
                else
                {
                    if (array[position] > largestNumber)
                        largestNumber = array[position];

                    return FindLargestNumberInnerRecursion(++position, largestNumber);
                }
            }
        }
    }
}
