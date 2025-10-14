using Tyuiu.LazutinVS.Sprint2.Task1.V8.Lib;

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
        int a = 15;
        int b = 16;
        int c = 14;
        int d = 335;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}