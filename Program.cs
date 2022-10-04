using System;

namespace ProjeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                AccessModifier returnType Method_Name(Parameter)
                {
                    Code
                }
            
            */
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int result1 = Sum(a,b);
            Console.WriteLine(result1);

            Methods value = new Methods();
            value.Screen(Convert.ToString(result1));
            int result2 = value.ChangeAndSum(ref a, ref b);
            value.Screen(Convert.ToString(result2));
            value.Screen(Convert.ToString(a+b));
        }

        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    class Methods
    {
        public void Screen(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ChangeAndSum(ref int number1, ref int number2)
        {
            number1 += 1;
            number1 += 1;
            return number1 + number2;
        }
    }
    
}
