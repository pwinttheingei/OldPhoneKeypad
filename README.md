Prerequisites

Make sure you have the following installed:

Visual Studio 2022
NET SDK
==========================================================
# Old Phone Pad Converter

## Description

The Old Phone Pad Converter is a C# console application that simulates the input of an old phone keypad. It converts a sequence of button presses into the corresponding alphabetical characters based on the typical mapping of numbers to letters on old mobile phones. 

Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.

For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.
You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.

### Features
- Convert sequences of key presses into text.
- Handles multiple presses of the same key for different letters.
- Prompts users to ensure that the input ends with a `#` character, which indicates the end of the input.

## How It Works

The application maps each number key (2-9) to its corresponding letters:
- 0: (space)
- 1: (No Letters)
- 2: A, B, C
- 3: D, E, F
- 4: G, H, I
- 5: J, K, L
- 6: M, N, O
- 7: P, Q, R, S
- 8: T, U, V
- 9: W, X, Y, Z

Users can input a sequence of button presses, and the program will translate it into text. Pressing the same button multiple times will cycle through the letters associated with that button. 

### Input Format
The input must be a sequence of numbers, where:
- Each number corresponds to a key on the keypad.
- Press the same number multiple times to select different letters.
- The input must end with a `#` to signify the completion of the input.

#### Example Input:
Enter input for the Old Phone Pad (“33#”) : => output: E
Enter input for the Old Phone Pad (“227*#”) => output: B
Enter input for the Old Phone Pad (“4433555 555666#”) => output: HELLO
Enter input for the Old Phone Pad (“8 88777444666*664#”) => output: TURIONG
