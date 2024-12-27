using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task3.V11.Lib
{
    public class DataService: ISprint2Task3V11
    {
        public double Calculate(double x) {
            double y = 0;
            if (x > 0)
            {
                y = x + Math.Pow((x - 15) / (x - 19), x);
            }
            else
            {
                if (x == 0)
                {
                    y = 3 / 4;
                }
                else
                {
                    if (-15 < x)
                    {
                        y = Math.Pow((1 + 1 / (x * x)), x);
                    }
                    else 
                    {
                        if (x < -15)
                        {
                            y = 11 * x - 1 / x;
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
