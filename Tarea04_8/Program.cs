using System;

namespace Tarea04_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Los primeros 100 números: ");
            while (num < 100)
            {
                num++;
                Console.Write(" " + num);
            }



            Console.ReadKey();
        }
    }
}
