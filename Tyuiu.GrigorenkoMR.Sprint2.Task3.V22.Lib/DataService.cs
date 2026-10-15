using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x + Math.Pow((x + 3) / (x - 1), x);
            }
            else if (x == 0)
            {
                double xSquared = x * x;
                y = (xSquared - Math.Cos(xSquared) + 10)
                  / (xSquared - Math.Sin(xSquared) + 12);
            }
            else if (x > -26 && x < 2)
            {
                y = Math.Pow(3 + 2 / (x * x), x);
            }
            else if (x < -26)
            {
                y = x + 10 * x - (1 / x);
            }
            else
            {
                throw new ArgumentException($"Значение x = {x} не входит ни в один диапазон");
            }

                return Math.Round(y, 3);
        }
    }
}
