string inputString = "HelloWorld";
string result = string.Empty;
foreach (char c in inputString)
{
if (char.IsUpper(c))
{
result += char.ToLower(c);
}
else
{
result += c;
}
}
Console.WriteLine(result);