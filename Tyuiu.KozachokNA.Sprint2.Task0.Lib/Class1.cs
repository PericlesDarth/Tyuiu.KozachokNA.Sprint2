using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task0.Lib
{
    public class Class1: ISprint2Task0V10
    {
        public bool[] GetCompareOperations(int a, int b)
        {
            bool[] result = new bool[6];
            result[0] = a == b;
            result[1] = a != b;
            result[2] = a < b;
            result[3] = a > b;
            result[4] = a <= b;
            result[5] = a >= b;
            return result;
        }
    }
}
