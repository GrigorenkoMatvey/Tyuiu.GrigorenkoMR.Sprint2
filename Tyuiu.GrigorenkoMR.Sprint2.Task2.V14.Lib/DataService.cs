using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;

            return
                (y == 2 && x >= 10 && x <= 13) ||
                (y == 3 && ((x >= 3 && x <= 5) || (x >= 10 && x <= 13))) ||
                (y == 4 && ((x >= 2 && x <= 5) || (x >= 10 && x <= 12))) ||
                (y == 5 && (x >= 2 && x <= 12)) ||
                (y == 6 && x >= 3 && x <= 8) ||
                (y == 7 && x >= 3 && x <= 8) ||
                (y == 8 && x >= 6 && x <= 8) ||
                (y == 9 && ((x >= 6 && x <= 8) || x == 13)) ||
                (y == 10 && ((x >= 6 && x <= 8) || x == 13)) ||
                (y == 11 && x >= 3 && x <= 13) ||
                (y == 12 && ((x >= 7 && x <= 10) || x == 13)) ||
                (y == 13 && x == 13);
        }
    }
}
