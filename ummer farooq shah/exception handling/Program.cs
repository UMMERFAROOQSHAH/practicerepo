namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = 5;
                int n2 = 0;
                int res = n1 / n2;
                Console.WriteLine("result= " + res);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("error"+ex.Message );
            }
        }
    }
}