namespace InsertionSort
{

    // Coding Question: Implement Insertion Sort to sort an integer array in ascending order.
    // Input: [7, 3, 5, 2, 8] → Output: [2, 3, 5, 7, 8]

    public class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 5, 2, 8 };

            InsertionSortMethod(numbers);

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        public static void InsertionSortMethod(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++) 
            {
                int current = numbers[i];
                int j = i - 1;

                while(j >= 0 && numbers[j] > current)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = current;
            }
            return;
        }
    }
}
