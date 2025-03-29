namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
            
        }

        public static string Add(int NumOne, int NumTwo, bool isMoney)
        {
            var sum = NumOne + NumTwo;
            if (isMoney && sum > 1)
            {
                return $" {sum} dollars";
            }

            else if (isMoney && sum == 1)
            {
                return $" {sum} dollar";
                
            }

            else
            {
                return sum.ToString();
            }

        }




        static void Main(string[] args)
        {
            Console.WriteLine(Add(20, 15, true));
        }


    }
}