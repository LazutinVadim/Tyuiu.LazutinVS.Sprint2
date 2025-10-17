using Tyuiu.LazutinVS.Sprint2.Task5.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        string res;
        if ((num < 1) || (num > 7))
        {
            res = "Ошибка!";
        }
        else
        {
            res = ds.FindDayName(num);
        }
        Console.WriteLine(res);
        Console.ReadKey();
    }
}