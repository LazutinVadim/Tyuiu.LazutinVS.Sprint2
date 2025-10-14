using Tyuiu.LazutinVS.Sprint2.Task4.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Лазутин В. С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                             *");
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
        double x, y;
        Console.WriteLine("* Введите значение X: ");

        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("* Введите значение Y: ");

        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (x < y + 2)
        {Console.Title = "Спринт #3 | Выполнил: Лазутин В. С. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                             *");
        Console.WriteLine("* Выполнил: Лазутин В. С.    | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
        }
        else
        {
            Console.WriteLine(ds.Calculate(x, y));
        }

    }
}