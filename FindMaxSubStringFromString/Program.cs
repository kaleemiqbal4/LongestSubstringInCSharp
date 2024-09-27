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
