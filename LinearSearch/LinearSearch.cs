namespace LinearSearch
{

    // Input:  numbers = [4, 7, 2, 9, 5], target = 9
    // Output: 3

    public class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] arr = [4, 7, 2, 9, 5];
            int target = 9;

            var result = LinearSearchMethod(arr, target);

            Console.WriteLine(result);
        }

        public static int LinearSearchMethod(int[] arr, int target)
        {

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }

            return -1;
        }
    }
}
