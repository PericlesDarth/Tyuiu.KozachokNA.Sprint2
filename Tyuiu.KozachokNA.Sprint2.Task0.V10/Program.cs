using Tyuiu.KozachokNA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KozachokNA.Sprint2.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            DataService dataService = new DataService();

            bool[] foo = dataService.GetCompareOperations(a, b);
            Console.Write(foo);

            Console.ReadKey();
        }
    }
}
