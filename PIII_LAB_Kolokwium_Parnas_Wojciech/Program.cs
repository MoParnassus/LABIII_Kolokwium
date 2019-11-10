using System;


namespace PIII_LAB_Kolokwium_Parnas_Wojciech
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            int x = 2;
            int y = 0;
            y = 2 * x ^ 3 - 8 * x ^ 2 - 3 * x + 10;

            Console.WriteLine("Podaj x =");
            Console.ReadLine();
            Console.Write("y =");
            Console.WriteLine(y);
        }
        
    }

}
