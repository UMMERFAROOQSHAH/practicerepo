﻿namespace ummer_farooq_shah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UMMER FAROOQ SHAH");
            Console.WriteLine("ROLL NMBR:21770022");
            int a = 55;
            int b = a;
            b = 900;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int[] arr = { 1, 2, 3, 4 };
            int[] arr2 = arr;
            arr2[0] = 10;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            int i = 10;
            int num = 5;
            Console.WriteLine("table of number 5 is as:-");
            for (i=1;i<=10;i++)
            {
               
                Console.WriteLine(  num+ "*"+i +" = " + num*i);
                //Console.WriteLine(i);

            }
        }
    }
}