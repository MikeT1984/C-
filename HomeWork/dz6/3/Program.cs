string inputString = "level";
bool isPalindrome = true;
for (int i = 0; i < inputString.Length / 2; i++)
{
if (inputString[i] != inputString[inputString.Length - 1 - i])
{
isPalindrome = false;
break;
}
}
if (isPalindrome)
{
Console.WriteLine("Строка является палиндромом.");
}
else
{
Console.WriteLine("Строка не является палиндромом.");
}