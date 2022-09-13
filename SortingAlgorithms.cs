using System.Runtime.ExceptionServices;

namespace Algorithms
{
    public static class SortingAlgorithms
    {
        #region Support methods
        public enum Order : byte
        { 
            Ascending = 0, 
            Descending = 1
        }

        private static void Swap(ref int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private static void Swap(ref char[] array, int index1, int index2)
        {
            char temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void FillArray(ref int[] array, int min, int max)
        {
            if (array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");

            ++max;

            Random random = new Random();

            for (int i = 0, length = array.Length; i < length; ++i)
                array[i] = random.Next(min, max);
        }

        public static int[] FillArray(int length, int min, int max)
        {
            int[] array = new int[length];

            FillArray(ref array, min, max);

            return array;
        }

        public static void PrintArray(ref int[] array)
        {
            if (array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");

            string result = String.Empty;

            for (int i = 0, length = array.Length; i < length; ++i)
                result += $"{array[i]}, ";

            result = result.Remove(result.Length - 2);
            result += ".";

            Console.WriteLine(result);
        }
        #endregion

        #region Sorting algorithms
        public static void SelectionSort(ref int[] array, Order order)
        {
            if (array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");

            switch (order)
            {
                case Order.Ascending:

                    int smallest;

                    for (int i = 0, length = array.Length; i < length; ++i)
                    {
                        smallest = i;

                        for (int j = i + 1; j < length; ++j)
                        {
                            if(array[j] < array[smallest])
                                smallest = j;
                        }

                        if (smallest != i)
                            Swap(ref array, i, smallest);
                    }

                    break;
                case Order.Descending:

                    int largest;

                    for (int i = 0, length = array.Length; i < length; ++i)
                    {
                        largest = i;

                        for (int j = i + 1; j < length; ++j)
                        {
                            if (array[j] > array[largest])
                                largest = j;
                        }

                        if (largest != i)
                            Swap(ref array, i, largest);
                    }

                    break;
            }
        }

        public static void SelectionSort(ref char[] array, Order order)
        {
            if (array == null)
                throw new System.ArgumentNullException($"{nameof(array)} is null.");

            switch (order)
            {
                case Order.Ascending:
                    int smallest;

                    for (int i = 0, length = array.Length; i < length; ++i)
                    {
                        smallest = array[i];

                        for (int j = i + 1; j < length; ++j)
                        {
                            if (array[j] < array[smallest])
                                smallest = j;
                        }

                        if (smallest != i)
                            Swap(ref array, i, smallest);
                    }
                    break;
                case Order.Descending:
                    int largest;

                    for (int i = 0, length = array.Length; i < length; ++i)
                    {
                        largest = array[i];

                        for (int j = i + 1; j < length; ++j)
                        {
                            if (array[j] > array[largest])
                                largest = j;
                        }

                        if (largest != i)
                            Swap(ref array, i, largest);
                    }
                    break;
            }
        }

        public static void QuickSort(ref int[] array, Order order)
        {

        }

        public static void QuickSort(ref char[] array, Order order)
        {

        }
        #endregion
    }
}
