using System.Reflection;

namespace Module3HW3
{
    public class Class2
    {
        public delegate int Delegate1(int value1, int value2);
        public delegate bool Delegate2(int value);
        public int Value { get; private set; }
        public Delegate2 Calc(Delegate1 pow, int value1, int value2)
        {
            Value = pow(value1, value2);
            return Result;
        }
        public bool Result(int value)
        {
            return (Value % value) == 0;
        }
    }
}
