namespace BinarySearch
{

    // Coding Question: Implement Binary Search to find the index of a target in a sorted integer array.
    // Input: [2, 4, 6, 8, 10, 12, 14], target = 10 → Output: 4

    public class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 4, 6, 8, 10, 12, 14];
            int target = 10;

            var result = BinarySearchMethod(arr, target);

            Console.WriteLine(result); // should be index 4
        }

        public static int BinarySearchMethod(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right) 
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target) return mid;

                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else right = mid - 1;  
            }

            return -1;
        }
    }
}
