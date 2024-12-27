using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task4.V14.Lib
{
    public class DataService: ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            double foo, bar, baz;
            foo = Math.Pow((2 + 1/(x*x)), y);
            bar = (y * y - Math.Cos(x) * Math.Cos(x) + 10) / (x * x + Math.Sin(y) * Math.Sin(y) + 12);
            baz = (3*x-20)<Math.Sqrt(y)?foo:bar;
            return Math.Round(baz, 3);
        }
    }
}
