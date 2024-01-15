System.Console.WriteLine("Input first number: ");
int number = Convert.ToInt32(Console.ReadLine());

void multiple(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine("Кратно 7 и 23 ");
    }
    else
    {
        System.Console.WriteLine("Не кратно 7 и 23 ");
    }
}

multiple(number);