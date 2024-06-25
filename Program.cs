using OOP2GroupLab1.ProblemDomain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {



            TextToList textToList = new TextToList();
            Console.WriteLine(textToList.TextIterator()[0][0]);

            Vacuum vacuum = new Vacuum(123123, "Miele", 20, 120, 139.99f, "Black", 24, "Residential");
            Console.WriteLine(vacuum.ToString());
            vacuum.IsAvailable();















            /*while (true)
            {
                // Start
                Console.Write(
                    "Welcome to Modern Appliances\n" +
                    "How may we assist you?\n" +
                    "1 - Check out appliance\n" +
                    "2 - Find appliances by brand\n" +
                    "3 - Display appliances by type\n" +
                    "4 - Produce random appliance list\n" +
                    "5 - Save & Exit\n" +
                    "Enter Option : ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (choice == 1) // Checkout
                {
                    // Define Item Number to checkout
                    Console.Write("Enter the Item Number of an appliance : ");
                    int searchNumber = int.Parse(Console.ReadLine());


                    // If Match Continue - If !Match Reset
                    *//*if (searchNumber in idNumbers)
                    {
                        Console.Write($"Appliance \"{searchNumber}\" has been checked out.");
                        // update quantity
                    }
                    else
                    {
                        Console.Write($"The appliance is not available to be checked out.");
                    }*//*
                    
                }
                else if (choice == 2) // Find by brand
                {
                    // Define Brand to be searched for
                    Console.Write("Enter brand to search for : ");
                    string searchBrand = Console.ReadLine();

                    // Iterate over each appliance checking for brand name
                    bool flag = false; // flag will trigger true if an appliance with a matching brand is found
                    *//*foreach (brand in brands)
                    {
                        if (searchBrand == brand)
                        {
                            // Run ToString method for appliance
                            flag = true;
                        }
                    }*//*
                    if (flag == false) // if no appliances found with matching brand
                    {
                        Console.WriteLine($"No {searchBrand} appliances found.");
                    }
                }
                else if (choice == 3) // Find by type
                {
                    Console.WriteLine("Three");
                }
                else if (choice == 4) // Random
                {
                    Console.WriteLine("Four");
                }
                else if (choice == 5) // Save & Exit
                {
                    Console.WriteLine("Five");
                }
                else
                {
                    Console.WriteLine("Input Invalid. Try Again\n");
                }
            }*/
        }
    }
}
