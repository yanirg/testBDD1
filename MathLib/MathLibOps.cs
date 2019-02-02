using System;


namespace MathLib
{
    public sealed class MathLibOps
    {

        public int _first;
        public int _second;
        public int AddFail(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Square(int num)
        {
            return num * num;
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
       
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }
    }
}
