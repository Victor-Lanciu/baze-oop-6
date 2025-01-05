namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations<int> intOperators = new MathOperations<int>();
            Console.WriteLine(intOperators.Divide(15, 5));
            Console.WriteLine(intOperators.Add(15, 5));

            MathOperations<double> doubleOperators = new MathOperations<double>();
            Console.WriteLine(doubleOperators.Multiply(2d, 5d));

            MathOperations<float> floatOperation = new MathOperations<float>();
            Console.WriteLine(floatOperation.Subtract(55f, 22f));
        }
    }
}
