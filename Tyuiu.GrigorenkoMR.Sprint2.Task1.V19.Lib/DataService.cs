using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            { (a > b) | (a > c),
              (a < b) & (b < c),
              (a > b) || (a < b),
              (a < b) && (b < c),
              !(a < b),
              (a > b) ^ (b < c)
            };
        }
    }
}
