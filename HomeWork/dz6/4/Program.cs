string inputString = "hello world";
string[] words = inputString.Split(' ');
Array.Reverse(words);
string reversedString = string.Join(" ", words);
Console.WriteLine(reversedString);