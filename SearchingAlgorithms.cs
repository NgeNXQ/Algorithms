namespace Algorithms
{
    internal static class SearchingAlgorithms
    {
        public static int BinarySearch(int[] array, int value)
        {
            if (array == null)
                return -1;

            int low = 0;
            int high = array.Length - 1;
            int mid;

            int guess;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = array[mid];

                if (guess == value)
                    return mid;
                else if (guess < value)
                    low = mid + 1;
                else 
                    high = mid - 1;
            }

            return -1;
        }

        public static int BinarySearch(char[] array, char value)
        {
            if (array == null)
                return -1;

            int low = 0;
            int high = array.Length - 1;
            int mid;

            int guess;

            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = array[mid];

                if (guess == value)
                    return mid;
                else if (guess < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}