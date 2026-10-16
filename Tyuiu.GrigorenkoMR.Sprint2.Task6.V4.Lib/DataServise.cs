using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrigorenkoMR.Sprint2.Task6.V4.Lib;

public class DataService : ISprint2Task6V4
{
    public string FindCardSuit(int m)
    {
        return m switch
        {
            1 => "пики",
            2 => "трефы",
            3 => "бубны",
            4 => "червы",
            _ => "Неизвестная масть"
        };
    }
}