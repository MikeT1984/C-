static int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

static void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


static void PrintResult(int[] array)
{
    Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));

    ReverseArray(array);

    Console.WriteLine("Реверсивный массив: " + string.Join(", ", array));
}

PrintResult(GenerateRandomArray(10, 100, 200));
