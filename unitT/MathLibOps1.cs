using System;


namespace MathLib1
{
    public sealed class MathLibOps1
    {
        public int num1;
        public int num2;
        public int AddFail(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Square(int num)
        {
            return num * num;
        }

        public int Add()
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
