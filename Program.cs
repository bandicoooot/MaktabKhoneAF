using System;

class Program
{
    static void Main()
    {
        //انجام تمرین حلقه با (while)
        // string input=Console.ReadLine();
        // if(int.TryParse(input,out int number) && number > 0)
        // {
        //     int sum = 0;
        //     int product = 1;
            
        //     int i =1;
        //     while (i<=number)
        //     {
        //         Console.WriteLine(i);
        //         sum += i;
        //         product*=i;

        //         i++;
                
        //     }
        //     Console.WriteLine($"Sum of numbers from 1 to {number}: {sum}");
        //     Console.WriteLine($"Product of numbers from 1 to {number}: {product}");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid input");
        // }
        

        //انجام همان تمرین با (for loops)


        string numbers=Console.ReadLine();
            int number =int.Parse(numbers);
            int jameadad=0;
            int zarbeadad=0;

        for(int i =1; i<=number;i++)
        {
            Console.WriteLine("\n"+i);
            jameadad+=i;
            zarbeadad+=i;
        }
        Console.WriteLine($"Sum of numbers from 1 to {number}: {jameadad}");
        Console.WriteLine($"Product of numbers from 1 to {number}: {zarbeadad}");


    }
}
