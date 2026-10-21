namespace ReverseStringOptimized
{
    public class ReverseStringOptimized
    {
        static void Main(string[] args)
        {
            var input = "madam";

            var result = ReverseStringMethod(input);

            Console.WriteLine("This is the result: " + result);
        }

        public static string ReverseStringMethod(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            char[] letters = new char[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                letters[i] = input[i];
            }
            
            while(left < right)
            {
                char temp = letters[left];
                letters[left] = letters[right];
                letters[right] = temp;

                left++;
                right--;
            }

            return new string(letters);
        }
    }
}
