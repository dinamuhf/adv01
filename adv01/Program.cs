 using System.Diagnostics.Metrics;

namespace adv_c_1
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                int[] numbers = { 64, 25, 12, 22, 11 };
                Console.WriteLine("Before Sorting: " + string.Join(", ", numbers));

                BubbleSortOptimized.Sort(numbers);

                Console.WriteLine("After Sorting: " + string.Join(", ", numbers));
            }
        }
    }
    #region 1
    class BubbleSortOptimized
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
    #endregion
