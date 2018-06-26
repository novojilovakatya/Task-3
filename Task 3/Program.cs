using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {

        /// <summary>
        /// Проверка ввода дробных чисел
        /// </summary>
        /// <returns>Целое дробных</returns>
        public static double ReadDoubly()
        {
            double k = 0; bool ok;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out k);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось целое число. Пожалуйста, повторите ввод");
            }
            while (!ok);
            return k;
        }

        static void Main(string[] args)
        {
            // Считываем значение x
            Console.WriteLine("Введите x");
            double x = ReadDoubly();
            // Считываем значение y
            Console.WriteLine("Введите y");
            double y = ReadDoubly();
            double u = 0;       // Результат

            // Вычисляем значение u в зависимости от принадлежности точки зашрихованной области
            if (x * x + (y - 1) * (y - 1) <= 1 && y <= 1 - x * x)
                u = x - y;
            else u = x * y + 7;

            // Выводим результат
            Console.WriteLine(u);
            Console.ReadLine();
        }
    }
}
