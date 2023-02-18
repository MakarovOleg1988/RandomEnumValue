using System;

namespace RandomEnumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var value = RandomEnumValue<DirectionType>();
                Console.WriteLine(value.ToString());
            }
        }

        static Random _R = new Random();
        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(_R.Next(v.Length));
        }
    }

    public enum DirectionType : int
    {
        Right,
        Left,
        Up,
        Down
    }
}
