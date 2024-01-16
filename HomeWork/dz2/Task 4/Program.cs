void DisplayDigits(int number)
{
    Console.Write("Цифры числа через запятую: ");

    string numberString = number.ToString();

    for (int i = 0; i < numberString.Length; i++)
    {
        Console.Write(numberString[i]);
        if (i < numberString.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
DisplayDigits(444);
