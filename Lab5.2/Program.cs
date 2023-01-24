using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        string num = Console.ReadLine();
        string[] numbers = new string[11] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-" };
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            string symbol = num[i].ToString();
            if (symbol == "-")
            {
                i += 1;
                symbol = num[i].ToString();
            }
            int index = MethodTwo(numbers, symbol);
            if (index != -1)
            {
                sum += index;
            }

        }
        if (sum == 0 && num != "0")
        {
            Console.WriteLine("Число некорректно");
        }
        else
        {
            Console.WriteLine("Сумма" + sum);
        }
    }

    static int MethodTwo(string[] numbers, string symbol)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == symbol)
            {
                return i;
            }
        }
        return -1;
    }
}