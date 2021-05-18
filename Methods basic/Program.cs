using System;

namespace Methods
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            num2 = 10;

            if (num1 > num2)
                result = num1;
            else
                result = num2 + num1;
            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //calling the FindMax method
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}
        