namespace Algorithms
{
    public static class SearchingAlgorithms
    {
        public static int BinarySearch(ref int[] array, int value)
        {
            if (array == null)
                return -1;
            else if (array.Length == 0)
                return -1;
            else
            {
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

        public static int BinarySearch(ref char[] array, char value)
        {
            if (array == null)
                return -1;
            else if (array.Length == 0)
                return -1;
            else
            {
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

        public static int BinarySearchRecursed(int[] array, int value)
        {
            if (array == null)
                return -1;
            else if (array.Length == 0)
                return -1;
            else
            {
                int low = 0;
                int high = array.Length - 1;

                return BinarySearchInnerRecursion(low, high);
            }

            int BinarySearchInnerRecursion(int low, int high)
            {
                if (low <= high)
                {
                    int mid = (low + high) / 2;
                    int guess = array[mid];

                    if (guess == value)
                        return mid;
                    else if (guess < value)
                        return BinarySearchInnerRecursion(mid + 1, high);
                    else
                        return BinarySearchInnerRecursion(low, mid - 1);
                }

                return -1;
            }
        }

        public static int BinarySearchRecursed(char[] array, char value)
        {
            if (array == null)
                return -1;
            else if (array.Length == 0)
                return -1;
            else
            {
                int low = 0;
                int high = array.Length - 1;

                return BinarySearchInnerRecursion(low, high);
            }

            int BinarySearchInnerRecursion(int low, int high)
            {
                if (low <= high)
                {
                    int mid = (low + high) / 2;
                    int guess = array[mid];

                    if (guess == value)
                        return mid;
                    else if (guess < value)
                        return BinarySearchInnerRecursion(mid + 1, high);
                    else
                        return BinarySearchInnerRecursion(low, mid - 1);
                }

                return -1;
            }
        }

        public static int BinarySearchRecursed(ref int[] array, int value, int low, int high)
        {
            throw new System.NotImplementedException();
        }

        public static int BinarySearchRecursed(ref char[] array, char value, int low, int high)
        {
            throw new System.NotImplementedException();
        }
    }
}