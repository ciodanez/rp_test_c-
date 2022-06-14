namespace Program.Functions
{
    public class Calculos
    {

        public static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static bool Primo(int num)
        {
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }
                if(count > 2)
                {
                    i = ++num;
                }
            }
            return count == 2;
        }

        static void Main(string[] args)
        {
        }
    }
}
