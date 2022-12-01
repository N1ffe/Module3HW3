using System.Reflection;

namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Class1.Delegate showDelegate = Show;
            showDelegate.Invoke(c2.Calc(c1.Pow, 5, 8).Invoke(4));
        }
        public static void Show(bool value)
        {
            Console.WriteLine(value);
        }
    }
}