using Tyuiu.AristovaAK.Sprint5.Task1.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("********************************************");
        Console.WriteLine("*   ТАБУЛИРОВАНИЕ ФУНКЦИИ                 *");
        Console.WriteLine("********************************************");
        Console.WriteLine();

        Console.WriteLine($"Стартовое значение: {startValue}");
        Console.WriteLine($"Конечное значение: {stopValue}");
        Console.WriteLine();

        double[,] functionTable = ds.GetFunctionTable(startValue, stopValue);
        Console.WriteLine("Таблица значений функции:");
        Console.WriteLine("  x   |   F(x)   ");
        Console.WriteLine("-----------------");

        for (int i = 0; i < functionTable.GetLength(0); i++)
        {
            double x = functionTable[i, 0];
            double y = functionTable[i, 1];
            Console.WriteLine($"{x,5:F1} | {y,8:F2}");
        }

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine();
        Console.WriteLine("********************************************");
        Console.WriteLine("*           РЕЗУЛЬТАТ                      *");
        Console.WriteLine("********************************************");

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}