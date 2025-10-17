using Tyuiu.LazutinVS.Sprint2.Task7.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        bool res;

        Console.WriteLine("Введите переменную X : ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите переменную Y : ");
        double y = Convert.ToDouble(Console.ReadLine());
        res = ds.CheckDotInShadedArea(x, y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
        Console.ReadKey();
    }
}