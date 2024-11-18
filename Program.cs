namespace Assignment_3_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.1.3
             *  Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
             *  Test Data :
             *  Please input a string : This is a test string.
             *  Expected Output :
             *  "This is a test string." contains 4 spaces
            */

            bool metConditions = false;
            try
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("Character Counter");
                    Console.WriteLine("\nEnter a string of text longer than 5 characters: ");
                    string stringEntry = Console.ReadLine();
                    
                    metConditions = (stringEntry != null && stringEntry.Length > 5);
                    
                    if (metConditions)
                    {
                        Console.WriteLine("\nWhat character would you like to be counted: ");
                        Char charEntry = Convert.ToChar(Console.Read());

                        int counter = CharCounter(stringEntry, charEntry);

                        Console.WriteLine($"\n\"{stringEntry}\" countains {counter} {charEntry}");
                        Console.ReadLine();
                    }
                }
                while (!metConditions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static int CharCounter(string myString, char myChar)
        {
            int myCharCount = 0;

            foreach (char c in myString)
            {
                if (c == myChar)
                    myCharCount++;
            }

            return myCharCount;
        }
    }
}
