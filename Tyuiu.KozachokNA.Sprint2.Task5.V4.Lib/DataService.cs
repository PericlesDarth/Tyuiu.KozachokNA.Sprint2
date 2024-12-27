using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task5.V4.Lib
{
    public class DataService: ISprint2Task5V4
    {
        public string FindCardSuit(int foo)
        {
            string bar = "";
            switch (foo)
            {
                case 1:
                    bar = "пики";
                    break;
                case 2:
                    bar = "трефы";
                    break;
                case 3:
                    bar = "бубны";
                    break;
                case 4:
                    bar = "червы";
                    break;
            }
            return bar;
        }
    }
}
