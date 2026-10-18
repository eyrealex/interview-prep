namespace BubbleSort
{

    // Coding Question: Implement Bubble Sort to sort an integer array in ascending order.
    // Input: [6, 3, 8, 1, 5] → Output: [1, 3, 5, 6, 8]

    public class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 3, 8, 1, 5 };

            BubbleSortMethod(numbers);

            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
        }

        public static int[] BubbleSortMethod(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
