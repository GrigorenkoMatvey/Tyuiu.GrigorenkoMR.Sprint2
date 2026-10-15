using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 0 || x > 15 || y < 0 || y > 15) 
                return false;

            return
                // Левый верхний блок
                (x >= 3 && x <= 5 && y >= 3 && y <= 6) ||
                (x >= 2 && x <= 5 && y >= 4 && y <= 6) ||

                // Центральный верх (Y = 5)
                (x >= 6 && x <= 8 && y == 5) ||

                // Центральный столб
                (x >= 4 && x <= 8 && y >= 7 && y <= 8) ||
                (x >= 6 && x <= 8 && y >= 7 && y <= 12) ||

                // Правый верх
                (x >= 10 && x <= 12 && y >= 2 && y <= 5) ||

                // Нижняя полоса
                (x >= 2 && x <= 12 && y == 11) ||
                (x >= 6 && x <= 11 && y == 12) ||

                // Правый хвост
                (x == 13 && y >= 9 && y <= 13);
        }
    }
}
