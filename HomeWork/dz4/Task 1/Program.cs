using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для завершения: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                int digitSum = CalculateDigitSum(number);

                if (digitSum % 2 == 0)
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
            }
        }
    }

    static int CalculateDigitSum(int num)
    {
        int sum = 0;
        num = Math.Abs(num); // Обрабатываем случай отрицательных чисел

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}
