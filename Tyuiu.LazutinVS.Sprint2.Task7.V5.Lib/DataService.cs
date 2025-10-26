using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.LazutinVS.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x >= 0)
            {
                if (((Math.Pow(x, 2) - 2) <= y) && (x >= y)) return true;
                else return false;
            }
            else if (((Math.Pow(x, 2) - 2) <= y) && (-x >= y)) return true;
            else return false;

        }
    }
}
