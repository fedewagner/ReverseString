namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Infinite loop, you control when to exit
            {
                // Create a program that asks the user for a string of input and simply returns it in reverse order. For instance, they enter “Hello” and it returns “olleH”.
                // Added Difficulty: Check if the given string is a palindrome.
                
                //STEPS
                // intro and ask user to enter a word to be chacked
                // check the length of that variable
                // for each element into that variable append that into a list and then count i--
                // then concatenate or append all the elements from the list into a variable
                //compare the variable (eventually make lowercase) and then if they are the same, then is a palindrome

                // intro and ask user to enter a word to be chacked
                string stringToReverse;
                Console.WriteLine("Please enter a string to reverse:");
                stringToReverse = Console.ReadLine().ToLower();

                // check the length of that variable
                int lengthOfString = stringToReverse.Length;

                // for each element into that variable append that into a list and then count i--
                var listReversedChars = new List<char>();

                for (int i = lengthOfString; i > 0; i--)
                {
                    listReversedChars.Add(stringToReverse[i - 1]);
                }

                //print reversed word            
                string reversedWord = new string(listReversedChars.ToArray());
                Console.WriteLine($"The reversed word is: {reversedWord}");

                if (Equals(stringToReverse, reversedWord))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The word is a palindrome!!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The word is not a palindrome :(");
                }
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Restart? (y/n)");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}