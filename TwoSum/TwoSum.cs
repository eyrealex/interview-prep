namespace TwoSum
{

    // Two Sum: Find two different elements in an array that add up to a target.
    // Return their indexes, or an empty array if no pair exists.
    // Example: [2, 3, 4, 7, 11, 15], target = 9 → [0, 3]
    // Brute Force: O(n²)
    public class TwoSum
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 3, 4, 7, 11, 15 };
            int target = 9;

            var result = TwoSumMethod(numbers, target);

            foreach (int index in result)
            {
                Console.WriteLine(index); // returns 0, 3
            }
        }

        public static int[] TwoSumMethod(int[] numbers, int target)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target) return new int[] { i, j };    
                }
            }
            return new int[0];
        }
    }
}
