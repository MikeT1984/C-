 void maxNumber(int num)
    {
        int max = 0;

        if (10 <= num && num <= 99)
        {
            int d1 = num % 10; // Последняя цифра
            int d2 = num / 10; // Первая цифра

            if (d1 > d2)
            {
                max = d1;
            }
            else
            {
                max = d2;
            }

            Console.WriteLine("max = " + max);
        }
        else
        {
            Console.WriteLine("Некорректное число");
        }
    }
maxNumber(12);
