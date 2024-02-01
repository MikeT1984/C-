char[,] charArray = {
{'a', 'b', 'c'},
{'d', 'e', 'f'},
{'g', 'h', 'i'}
};

string result = string.Empty;
for (int i = 0; i < charArray.GetLength(0); i++)
{
for (int j = 0; j < charArray.GetLength(1); j++)
{
result += charArray[i, j];
}
}
Console.WriteLine(result);