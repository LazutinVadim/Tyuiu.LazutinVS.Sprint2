using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LazutinVS.Sprint2.Task2.V25.Lib
{
   
        public class DataService : ISprint2Task2V25
        {
            public bool CheckDotInShadedArea(int x, int y)
            {
                int[,] array = new int[10, 13]
                {
                {0,0,1,1,1,0,0,0,1,1,1,1,0},
                {0,0,1,1,1,0,0,0,1,1,1,1,0},
                {1,1,1,1,1,1,1,1,1,1,1,1,0},
                {1,1,1,1,1,1,1,1,1,1,1,1,1},
                {0,0,1,1,1,1,1,1,1,1,1,1,1},
                {0,0,0,0,0,1,1,1,1,1,1,1,1},
                {0,0,0,0,0,1,1,0,0,1,1,0,0},
                {0,0,0,0,0,1,1,0,0,1,1,0,0},
                {0,0,1,1,1,1,1,0,0,1,1,0,0},
                {0,0,0,0,0,0,1,0,0,1,0,0,0}
                };
                if (array[x, y] == 0)
                {
                    return false;
                }
                return true;
            }
        
    }
}
