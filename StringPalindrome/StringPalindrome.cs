
namespace StringPalindrome
{
    internal class StringPalindrome
    {
        static void Main(string[] args)
        {
            string input = "racecar";

            var result = IsPalindrome(input);

            Console.WriteLine(result);
        }

        public static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            
            while (left < right) 
            {
                if (input[left] != input[right]) return false;

                left++;
                right--;
            }
  
            return true;
        }
    }
}
