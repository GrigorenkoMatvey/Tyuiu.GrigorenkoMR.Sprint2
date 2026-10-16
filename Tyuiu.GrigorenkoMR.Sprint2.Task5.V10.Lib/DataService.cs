using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
                return $"{n - 1:D2}.{m:D2}.{g}";

            switch (m)
            {
                case 1: return $"31.12.{g - 1}";
                case 2: return $"31.01.{g}";
                case 3: return $"28.02.{g}";
                case 4: return $"31.03.{g}";
                case 5: return $"30.04.{g}";
                case 6: return $"31.05.{g}";
                case 7: return $"30.06.{g}";
                case 8: return $"31.07.{g}";
                case 9: return $"31.08.{g}";
                case 10: return $"30.09.{g}";
                case 11: return $"31.10.{g}";
                case 12: return $"30.11.{g}";
                default: throw new ArgumentException("Некорректный месяц");
            }
        }
    }
}
