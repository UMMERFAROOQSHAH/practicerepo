namespace clas_n_object
{
    public class Reg
    {
        public Reg(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
    abstract class abc

    {
        abstract public void force();
    }
    partial class Par : abc
    {
        public override void force()
        {
            Console.WriteLine("abstract method inside par");
        }
        public void frstpar()
        {
            Console.WriteLine("from 1st par method");
        }

    }
    partial class Par
    {
        public void secpar()
        {
            Console.WriteLine("from 2nd par method");
        }
    }
    sealed class pqr : abc
    {
        public override void force()
        {
            Console.WriteLine("abstract method inside sealed example");
        }
        public void message()
        {
            Console.WriteLine("from sealed method");
        }
    }
    static class sta
    {
        public static void message()
        {
            Console.WriteLine("from static method");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Reg obj1 = new Reg(5, 15);
            Par obj2 = new Par();
            obj2.frstpar();
            obj2.secpar();
            obj2.force();
            sta.message();

        }

    }
}