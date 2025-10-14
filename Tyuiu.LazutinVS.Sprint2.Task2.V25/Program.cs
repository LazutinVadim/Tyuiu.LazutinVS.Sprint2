using Tyuiu.LazutinVS.Sprint2.Task2.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Лазутин В. С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Лазутин В. С.    | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int x,y;
        Console.WriteLine("Введите значение переменной X: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (ds.CheckDotInShadedArea(x, y) == true)
        {
            Console.WriteLine($"Точка ({x},{y}) в заштрихованной области");
        }
        else { Console.WriteLine($"Точка ({x},{y}) не в заштрихованной области"); }
        Console.ReadKey();
    }
}