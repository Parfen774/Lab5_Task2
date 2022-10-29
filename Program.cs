using System;

namespace Program
{
    class Program
    {
        public static bool IsNumber(string line)
        {
            foreach (var item in line)
                if (!char.IsDigit(item))
                    return false;

            return true;
        }

        public static int Summa(string line)
        {
            int sum = 0;

            foreach (char item in line)
                sum += item - 48;

            return sum;
        }

        public static void Main()
        {
            Console.Write("Введите число: ");
            string line = Console.ReadLine();

            if (IsNumber(line))
                Console.WriteLine($"Сумма чисел: {Summa(line)}");
            else
                Console.WriteLine("Некоррктное число!");
        }
    }
}