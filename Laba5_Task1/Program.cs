using System;
namespace Laba5
{
    class Task1
    {
        static void Main()
        {
            double earlyNumber = 0;
            for (; ; )
            {
                string number = Console.ReadLine();
                if (number == "q")
                {
                    break;
                }
                if (int.TryParse(number, out int result))
                {
                    Console.WriteLine((char)result);
                }
                if (Convert.ToDouble(number) == Convert.ToDouble(earlyNumber))
                {
                    break;
                }
                earlyNumber = Convert.ToDouble(number);
            }

        }
    }
}