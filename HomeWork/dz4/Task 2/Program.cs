
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

static int CountEvenItems(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

static void PrintResult(int[] array)
{
   // Console.WriteLine("Сгенерированный массив:");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write(array[i] + " ");
    // }
    // Console.WriteLine();
    Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
    int countEvenNumbers = CountEvenItems(array);
    Console.WriteLine($"Количество четных чисел: {countEvenNumbers}");
}
PrintResult(GenerateRandomArray(10, 100, 200));