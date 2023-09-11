using System;

public class Program
{
    public static void Main()
    {
        int sodaRestock = 40;
        int chipRestock = 20;
        int candyRestock = 40;
     
        Console.WriteLine("Welcome to the restocking tool!");

        //Soda Code
        Console.WriteLine("How many sodas have been sold today? 100 are in stock");
            int sodaStock = 100 - int.Parse(Console.ReadLine());
        if (sodaStock < 0)
        {
            sodaStock = 100;
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There are " + sodaStock + " sodas left");
        }

        //Chips Code
        Console.WriteLine("How many chips have been sold today? 40 are in stock");
            int chipStock = 40 - int.Parse(Console.ReadLine());
        if (chipStock < 0)
        {
            chipStock = 40;
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There are " + chipStock + " chips left");
        }

        //Candy Code
        Console.WriteLine("How much candy has been sold today? 60 are in stock");
            int candyStock = 60 - int.Parse(Console.ReadLine());
        if (candyStock < 0)
        {
            candyStock = 60;
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There is " + candyStock + " candy left");
        }
    
        //Restock Code

        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked:");
            if (sodaStock <= sodaRestock)
        {
            Console.WriteLine("Soda needs to be restocked");
        }
            if (chipStock <= chipRestock)
        {
            Console.WriteLine("Chips need to be restocked");
        }
            if(candyStock <= candyRestock)
        {
            Console.WriteLine("Candy needs to be restocked");
        }
        Console.WriteLine("Goodbye!");

    }
}