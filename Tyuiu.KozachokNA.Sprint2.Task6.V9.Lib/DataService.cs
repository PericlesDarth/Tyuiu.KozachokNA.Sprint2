using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozachokNA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int foo = m;
            int bar = n;
            string baz = "";
            switch (foo)
            {
                case (1):
                    if (bar < 31) {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (2):
                    if (bar < 28)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (3):
                    if (bar < 31)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (4):
                    if (bar < 30)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (5):
                    if (bar < 31)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (6):
                    if (bar < 30)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (7):
                    if (bar < 31)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (8):
                    if (bar < 31)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (9):
                    if (bar < 30)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (10):
                    if (bar < 31)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (11):
                    if (bar < 30)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
                case (12):
                    if (bar < 31)
                    {
                        bar++;
                    }
                    else
                    {
                        foo++; bar = 1;
                    }
                    break;
            }
            switch (foo)
            {
                case 1:
                    baz = "Января";
                    break;
                case 2:
                    baz = "Февраля";
                    break;
                case 3:
                    baz = "Марта";
                    break;
                case 4:
                    baz = "Апреля";
                    break;
                case 5:
                    baz = "Мая";
                    break;
                case 6:
                    baz = "Июня";
                    break;
                case 7:
                    baz = "Июля";
                    break;
                case 8:
                    baz = "Августа";
                    break;
                case 9:
                    baz = "Сентября";
                    break;
                case 10:
                    baz = "Октября";
                    break;
                case 11:
                    baz = "Ноября";
                    break;
                case 12:
                    baz = "Декабря";
                    break;
            }
            baz = Convert.ToString(bar) + " " + baz;
            return baz;
        }
    }
}
