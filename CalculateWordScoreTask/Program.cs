namespace CalculateWordScoreTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter a word or phrase to calculate the score: ");
            input = Console.ReadLine ();
            string onlyLetters = removeNonLetters(input);

            // Your task is to calculate the score of the word or phrase
            // convert each letter to its ascii value and sum them up
            // print the score
            // Write your code here
            // Show your evidence by testing with your full name as an input
        }

        // This method removes all non-letter characters from the input string

        static string removeNonLetters(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    result += c;
                }
            }
            return result.ToUpper();
        }
    }
}
