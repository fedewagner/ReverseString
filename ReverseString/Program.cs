namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks the user for a string of input and simply returns it in reverse order. For instance, they enter “Hello” and it returns “olleH”.
            // Added Difficulty: Check if the given string is a palindrome.
            
            
            // intro and ask user to enter a word to be chacked
            // check the length of that variable
            // for each element into that variable append that into a list and then count i--
            // then concatenate or append all the elements from the list into a variable
            //compare the variable (eventually make lowercase) and then if they are the same, then is a palindrome

            // intro and ask user to enter a word to be chacked
            string stringToReverse;
            Console.WriteLine("Please enter a string to reverse:");
            stringToReverse = Console.ReadLine();

            // check the length of that variable
            int lengthOfString = stringToReverse.Length;
            
                
            /*//
            for each element
            into that variable append that into a list and then count i--
            var charsToReverse = new List<string>();
            foreach (char item in stringToReverse)
            {
                charsToReverse.Add(item);
            }*/

            // for each element into that variable append that into a list and then count i--
            for (int i = lengthOfString; i > 0; i--)
            {
                Console.Write(stringToReverse[i-1]);
            }


        }
    }
}