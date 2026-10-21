namespace ReverseString
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            var input = "hello";

            var result = ReverseStringMethod(input);

            Console.WriteLine("This is the result: " + result);
        }

        public static string ReverseStringMethod(string input)
        {
            char[] letters = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                letters[i] = input[i];

            }

            for(int i = 0; i < input.Length / 2; i++) {

                for(int j = input.Length - 1; j >= 0; j--)
                {
                    if(i + j == letters.Length - 1)
                    {
                        char swap = letters[j];
                        letters[j] = letters[i];
                        letters[i] = swap;
                        break;
                    }
                }
            }

            return new string(letters);
        } 
    }
}
