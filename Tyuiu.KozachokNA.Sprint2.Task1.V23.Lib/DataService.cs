using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task1.V23.Lib
{
    public class DataService: ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | false;
            res[1] = (c == d) & false;
            res[2] = (a < d) || false;
            res[3] = (b > c) && true;
            res[4] = !(b <= a);
            res[5] = (c >= d) ^ false;
            return res;
        }
    }
}
