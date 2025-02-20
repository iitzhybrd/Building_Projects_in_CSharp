using System;

namespace CurrencyTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome! Please enter 'c' to use the currency converter or anything else to use the temperature converter");
            string answer = Console.ReadLine();

            if(answer == "c")
            {
                System.Console.WriteLine("You have selected the currency converter.");
                System.Console.WriteLine("Please enter 'a' to convert from pounds or anything else to euros.");
                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    System.Console.WriteLine("Please enter your amount in British pounds.");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    System.Console.WriteLine("The amount in euros is " + euros.ToString("0.00"));
                }
                else
                {
                    System.Console.WriteLine("Please enter your amount in euros.");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;
                    System.Console.WriteLine("The amount in British pounds is " + pounds.ToString("0.00"));
                }
            }
            else
            {
                System.Console.WriteLine("Welcome to the temp converter!");
                System.Console.WriteLine("Please enter 'a' to convert from celcius or anything else to convert from farenheit.");
                string choice = Console.ReadLine();

                if( choice == "a")
                {
                    System.Console.WriteLine("Enter a temp in celcius.");
                    float celcius = float.Parse(Console.ReadLine());
                    float farenheit = celcius * 1.18f + 32f;
                    System.Console.WriteLine("The temp in farenheit is " + farenheit);
                }
                else
                {
                    System.Console.WriteLine("Please enter a temp in farenheit.");
                    float farenheit = float.Parse(Console.ReadLine());
                    float celcius = (farenheit - 32f) / 1.8f;
                    System.Console.WriteLine("The temp in celcius is " + celcius);
                }
            }
        }
    }
}