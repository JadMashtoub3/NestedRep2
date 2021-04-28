using System;

namespace NestedRep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the width you desire");
            int width = int.Parse( Console.ReadLine() );
            Console.Write("x");
            for(int i = 1; i <= width;  i++  )
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        } 
    }
}
