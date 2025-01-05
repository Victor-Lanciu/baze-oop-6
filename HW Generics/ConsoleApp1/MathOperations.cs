using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MathOperations<T> where T : INumber<T>
    {
        public T Add(T a, T b)
        {
            return a + b;
        }
        public T Subtract(T a, T b)
        {
            return a - b;
        }
        public T Multiply(T a, T b)
        {
            return a * b;
        }
        public T Divide(T a, T b)
        {
            if (b == T.Zero)
            {
                throw new ArgumentException("Dividing by zero is undefined");
            }
            return a / b;
        }


    }
}
