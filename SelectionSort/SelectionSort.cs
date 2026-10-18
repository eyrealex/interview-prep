namespace SelectionSort
{

    // Coding Question: Implement Selection Sort to sort an integer array in ascending order.
    // Input: [5, 2, 8, 1, 3] → Output: [1, 2, 3, 5, 8]

    public class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 3 };

            SelectionSortMethod(numbers);

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        public static void SelectionSortMethod(int[] numbers)
        {

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min = i;

                for(int j = i + 1;  j < numbers.Length; j++)
                {
                    if(numbers[j] < numbers[min]) min = j;
                }

                int temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }

            return;
        }
    }
}
