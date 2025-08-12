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
#region 2
class Program
{
    static void Main()
    {
        Range<int> intRange = new Range<int>(10, 20);

        Console.WriteLine("Is 15 in range? " + intRange.IsInRange(15)); // True
        Console.WriteLine("Is 25 in range? " + intRange.IsInRange(25)); // False
        Console.WriteLine("Range length: " + intRange.Length()); // 10

        Range<double> doubleRange = new Range<double>(5.5, 10.5);
        Console.WriteLine("Is 7.2 in range? " + doubleRange.IsInRange(7.2)); // True
        Console.WriteLine("Range length: " + doubleRange.Length()); // 5.0
    }
}
class Range<T> where T : IComparable<T>
{
    public T Min { get; }
    public T Max { get; }

    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
            throw new ArgumentException("Minimum value cannot be greater than maximum value.");

        Min = min;
        Max = max;
    }

    public bool IsInRange(T value)
    {
        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    }

    public double Length()
    {
        dynamic minValue = Min;
        dynamic maxValue = Max;
        return (double)(maxValue - minValue);
    }
}

#endregion