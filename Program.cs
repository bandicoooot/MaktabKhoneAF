using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int counter=0;
        while (counter<5)
        {
            Console.WriteLine("adad aval: ");
            string input_1=Console.ReadLine();
            int Num_1=int.Parse(input_1);

            Console.WriteLine("adad dovom: ");
            string input_2 = Console.ReadLine();
            int Num_2=int.Parse(input_2);

            Console.WriteLine("+ or * or / or -: ");
            string input_3 = Console.ReadLine();
            switch(input_3)
            {
                case "+":
                Console.WriteLine(Num_1 + Num_2);
                break;

                case  "*":
                Console.WriteLine(Num_1 * Num_2);
                break;

                case "/":
                Console.WriteLine(Num_1 / Num_2);
                break;

                case "-":
                Console.WriteLine(Num_1 - Num_2);
                break;
            }
             counter++;

        }
       
        Console.WriteLine("The program has finished executing 5 times.");

        

        



    }
    

}
