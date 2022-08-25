namespace Chapter7p59
{
    static class IntExtensions
    {
        public static int GetNegative(this int a)
        {
            if (a > 0)
                 return -a;
            else return a;
        }
        public static int GetPositive(this int a)
        {
            if (a < 0)
                return -a;
            else return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;


            Console.WriteLine(num1.GetNegative());
            Console.WriteLine(num1.GetPositive());

            Console.WriteLine(num2.GetNegative());
            Console.WriteLine(num2.GetPositive());

            Console.WriteLine(num3.GetNegative());
            Console.WriteLine(num3.GetPositive());



        }
    }
}