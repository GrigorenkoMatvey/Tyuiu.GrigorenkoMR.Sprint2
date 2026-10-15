using Tyuiu.GrigorenkoMR.Sprint2.Task1.V19.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и       *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^), а также арифметических        *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность:                *");
            Console.WriteLine("* (True, False, True, False, True, False),                                *");
            Console.WriteLine("* при a = 696, b = 354, c = 423, d = 957.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b, c, d;
            Console.WriteLine(" Введите значение переменной A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной B:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной C:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите значение переменной D:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("[" + string.Join(", ", res) + "]");
            Console.ReadLine();
        }
    }
}
