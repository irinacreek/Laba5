using System;
using System.Linq;

namespace Task4
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Введите число элементов в массиве:");
            int count = int.Parse(Console.ReadLine());
            string[] numbers = new string[count];
            double[] result = new double[count];

            Console.WriteLine($"Введите элементы массива:");
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < count; i++)
            {
                bool flag = int.TryParse(numbers[i], out int intNumber);

                if (intNumber > 0 && flag)
                {
                    result[i] = Factorial(intNumber);
                }

                else if (intNumber < 0 && flag)
                {
                    result[i] = intNumber;
                }

                else
                {
                    double doubleNumber = double.Parse(numbers[i]);
                    doubleNumber = Math.Round(doubleNumber, 2);
                    string[] parts = (doubleNumber.ToString()).Split(',');
                    result[i] = double.Parse(parts[1]);
                }
                Console.WriteLine(result[i]);
            } 
        }
        public static double Factorial(double numer)
        {
            int factorial = 1;
            for (int i = 2; i <= numer; i++)
                factorial *= i;
            return factorial;
        }
    }
}