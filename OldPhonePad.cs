using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadConverter
{
    public class OldPhonePad
    {
        private static readonly Dictionary<char, string> PhoneKeyMapping = new Dictionary<char, string>
        {
            { '0'," "},
            { '1', ""},
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" }
        };

        public string ConvertInput(string input)
        {
            if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
            {
                throw new ArgumentException("Input must end with #.");
            }
            //// If the input doesn't end with #, append it
            //if (!input.EndsWith("#"))
            //{
            //    input += "#";
            //}

            StringBuilder output = new StringBuilder();
            char[] inputChars = input.TrimEnd('#').ToCharArray();
            int length = inputChars.Length;

            for (int i = 0; i < length; i++)
            {
                char currentChar = inputChars[i];
                int count = 1;

                // Count repeated characters
                while (i + 1 < length && inputChars[i + 1] == currentChar)
                {
                    count++;
                    i++;
                }

                // Determine which letter to append to the output
                if (PhoneKeyMapping.ContainsKey(currentChar))
                {
                    string letters = PhoneKeyMapping[currentChar];
                    // Use modulo to wrap around if count exceeds the number of letters
                    char letter = letters[(count - 1) % letters.Length];
                    output.Append(letter);
                }
            }

            return output.ToString();
        }
    }
}

