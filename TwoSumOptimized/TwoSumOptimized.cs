namespace TwoSumOptimized
{

    // Two Sum: Find two different elements in an array that add up to a target.
    // Return their indexes, or an empty array if no pair exists.
    // Example: [2, 3, 4, 7, 11, 15], target = 9 → [0, 3]
    // Optimized (sorted array): O(n) using two pointers.
    public class TwoSumOptimized
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 7, 11, 15 };
            int target = 9;

            var result = TwoSumOptimizedMethod(numbers, target);

            foreach (int index in result)
            {
                Console.WriteLine(index); // returns {0, 3}
            }
        }

        public static int[] TwoSumOptimizedMethod(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] == target) return new int[] {left, right };
                
                if(numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new int[0];
        }
    }
}
