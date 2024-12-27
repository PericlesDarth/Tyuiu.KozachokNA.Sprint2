using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task2.V16.Lib
{
    public class DataService: ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y == 3 && ((3 <= x && x <= 5) || (13 <= x && x <= 14)) ||
                y == 4 && ((3 <= x && x <= 5) || (13 <= x && x <= 14)) ||
                y == 5 && ((3 <= x && x <= 7) || (13 <= x && x <= 14)) ||
                y == 6 && ((3 <= x && x <= 9) || (13 <= x && x <= 14)) ||
                y == 7 && ((3 <= x && x <= 14)|| (13 <= x && x <= 14)) ||
                y == 8 && (6 <= x && x <= 9)  ||
                y == 9 && (6 <= x && x <= 7)  ||
                y == 10 && (6 <= x && x <= 7) ||
                y == 11 && (3 <= x && x <= 7) ||
                y == 12 && ((x == 3) || (7 <= x && x <= 10)) ||
                y == 13 && ((x == 3) || (10 <= x && x <= 12)))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
