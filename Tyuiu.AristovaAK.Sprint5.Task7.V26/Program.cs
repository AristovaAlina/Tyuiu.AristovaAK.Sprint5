using Tyuiu.AristovaAK.Sprint5.Task7.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть набор символьных данных.Заменить все           *");
        Console.WriteLine("* английские слова на слово 'word'.Полученный результат сохранить в       *");
        Console.WriteLine("* файл OutPutDataFileTask7V26.txt.                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V26.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        string tempPath = Path.GetTempPath();
        string inputFilePath = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V26.txt");
        string outputFilePath = Path.Combine(tempPath, "OutPutDataFileTask7V26.txt");

        string res = ds.LoadDataAndSave(path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}