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
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ И РЕЗУЛЬТАТ:                                            *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("  x   |   F(x)   ");
        Console.WriteLine("-----------------");

        for (int x = startValue; x <= stopValue; x++)
        {
            double y = Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6;
            y = Math.Round(y, 2);
            Console.WriteLine($"{x,5} | {y,8:F2}");
        }

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}