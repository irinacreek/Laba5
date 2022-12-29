using System;
namespace Laba5
{
    class Task2
    {
        static void Main()
        {
            bool flag = true;
            int sum = 0;
            string number = Console.ReadLine();
            number = number.Replace("-", "");
            for (int i = 0; i < number.Length; i++)
            {
                if (!Char.IsDigit(number[i]))
                {
                    Console.WriteLine("Число не целое.");
                    flag = false;
                    break;
                }
                char symbol = (char)number[i];
                sum += symbol - '0';
            }

            if (flag) Console.WriteLine($"Сумма цифр введенного числа: {sum}.");
        }
    }
}
