using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task7.V13.Lib
{
    public class DataService: ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool foo = (y < 1) && (y > x - 1);
            bool bar = ((x * x + y * y) < 1);
            if ((x > 0) && (foo || bar))
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
