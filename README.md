# Longest Substring Without Repeating Characters

This console application takes a string input from the user and finds the longest substring that contains all unique characters. It outputs the longest substring without repeating characters.

## Table of Contents

- [Getting Started](#getting-started)
- [How It Works](#how-it-works)
- [Usage](#usage)
- [Example Input and Output](#example-input-and-output)
- [License](#license)

## Getting Started

To run this application, you'll need the .NET SDK installed on your machine. You can download it from [the official .NET website](https://dotnet.microsoft.com/download).

### Prerequisites

- .NET SDK
- A text editor or an IDE (e.g., Visual Studio, Visual Studio Code)

## How It Works

1. The program prompts the user to enter a string.
2. It processes the input to find the longest substring of characters that do not repeat.
3. It utilizes a `StringBuilder` to construct substrings and a list to store valid substrings.
4. Finally, it determines and displays the longest valid substring.

## Usage

1. Clone this repository or download the code.
2. Open a terminal and navigate to the project directory.
3. Run the application using the command:

   ```bash
   dotnet run
   ```

## Enter a string to find longest characters substring

- abcabcbb
- Longest substring without repeating characters: abc

using System.Text;

Console.WriteLine("Enter a string to find longest characters substring");
string input = Console.ReadLine();
List<string> list = new List<string>();
StringBuilder noRepeatingCharacters = new();
for (int i = 0; i < input.Length; i++)
{
if (noRepeatingCharacters.ToString().Contains(input[i]))
{
list.Add(noRepeatingCharacters.ToString());
noRepeatingCharacters.Clear();
}
noRepeatingCharacters.Append(input[i]);
}

list.Add(noRepeatingCharacters.ToString());
var result = list.MaxBy(word => word.Length);
Console.WriteLine($"Longest substring without repeating characters: {result}");
