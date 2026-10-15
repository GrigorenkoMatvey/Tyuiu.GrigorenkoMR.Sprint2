using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x + y == x - y,
                x * y != y * x,
                x < y,
                y > x,
                x + y <= y - x,
                x - y >= y - x
            };
        }
    }
}
