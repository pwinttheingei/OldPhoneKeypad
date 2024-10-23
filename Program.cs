using OldPhonePadConverter;

public class Program
{
    public static void Main(string[] args)
    {
        OldPhonePad phonePad = new OldPhonePad();

        while (true) // Repeat until valid input is provided
        {
            Console.Write("Enter input for the Old Phone Pad (end with #): ");
            string userInput = Console.ReadLine();

            // Check if the input ends with '#'
            if (!userInput.EndsWith("#"))
            {
                Console.WriteLine("Please make sure to add '#' at the end of your input.");
            }
            else
            {
                try
                {
                    // Process the input and display the output
                    string result = phonePad.ConvertInput(userInput);
                    Console.WriteLine("Output: " + result);
                    break; // Exit the loop when input is valid
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
