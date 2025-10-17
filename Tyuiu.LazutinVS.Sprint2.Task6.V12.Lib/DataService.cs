using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.LazutinVS.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 => 31,
                2 => 29,  // В високосном году в феврале 29 дней
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new ArgumentOutOfRangeException("Некорректный номер месяца")
            };

            // Если это не первый день месяца
            if (n > 1)
            {
                n -= 1;

            }
            else
            {
                // Переход к предыдущему месяцу
                m = m == 1 ? 12 : m - 1;
                g = m == 12 ? g - 1 : g;

                // Количество дней в предыдущем месяце
                int prevMonthDays = m switch
                {
                    1 => 31,
                    2 => 29,  // Високосный год
                    3 => 31,
                    4 => 30,
                    5 => 31,
                    6 => 30,
                    7 => 31,
                    8 => 31,
                    9 => 30,
                    10 => 31,
                    11 => 30,
                    12 => 31,
                    _ => throw new ArgumentOutOfRangeException("Некорректный номер месяца")
                };

                n = prevMonthDays;
            }
            return $"{n:00}.{m:00}.{g}";
        }
    }
}