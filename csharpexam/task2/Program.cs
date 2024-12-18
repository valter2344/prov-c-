/*
 * C# Program to Accept a Number from the user and Display it 
 * if it is Positive
 */
using System;
class program
{
    public static void Main(string[] args)
    {    //Code that propts the user to enter a number 
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        //Checks if positive
        if (number > 0)
        {     
            Console.WriteLine("The number is positive");
        }
        //checks if number == 0
        else if (number == 0)
        {
            Console.WriteLine("The number is 0");
        }
        //checks if number is negative
        else
        {
            Console.WriteLine("The number is negative");
        }
        Console.ReadLine();
    }
}
