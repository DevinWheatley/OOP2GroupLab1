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
            // Store appliances into lists based on their ID#
            SetType setType = new SetType();
            setType.SetApplianceType();


            while (true)
            {
                // Print Menu
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

                // Menu Selections
                if (choice == 1) // Checkout
                {
                    // Define Item Number to checkout
                    Console.Write("Enter the Item Number of an appliance : ");
                    int searchNumber = int.Parse(Console.ReadLine());

                    bool flag = false; // true if Item Number found
                    int index = 0;
                    foreach (Appliance appliance in setType.appliances)
                    {
                        // Check searchNumber against appliance Item Numbers
                        if (searchNumber == setType.appliances[index].itemNumber)
                        {
                            Console.WriteLine($"Appliance \"{searchNumber}\" has been checked out.\n");
                            // Update quantity
                            setType.appliances[index].quantity--;
                        }
                        index++;
                    }
                    // if no matching Item Number found
                    if (flag == false) { Console.WriteLine($"No item with matching Item Number.\n"); }
                }
                /*else if (choice == 2) // Find by brand
                {
                    
                    // Define Brand to be searched for
                    Console.Write("Enter brand to search for : ");
                    string searchBrand = Console.ReadLine();

                    // Iterate over each appliance checking for brand name
                    bool flag = false; // flag will trigger true if an appliance with a matching brand is found
                    foreach (brand in brands)
                    {
                        if (searchBrand == brand)
                        {
                            // Run ToString method for appliance
                            flag = true;
                        }
                    }
                    if (flag == false) // if no appliances found with matching brand
                    {
                        Console.WriteLine($"No {searchBrand} appliances found.");
                    }
                }*/
              
                else if (choice == 3) // Find by type
                {
                    
                    Console.WriteLine("Select Appliance Type:");
                    Console.WriteLine("1 – Refrigerators");
                    Console.WriteLine("2 – Vacuums");
                    Console.WriteLine("3 – Microwaves");
                    Console.WriteLine("4 – Dishwashers");
                    Console.Write("Enter option: ");
                    int typeChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    string searchType = "";
                    switch (typeChoice)
                    {
                        case 1:
                            searchType = "refrigerator";
                            break;
                        case 2:
                            searchType = "vacuum";
                            break;
                        case 3:
                            searchType = "microwave";
                            break;
                        case 4:
                            searchType = "dishwasher";
                            break;
                        default:
                            Console.WriteLine("Invalid type selected.");
                            continue;
                    }

                    //check type
                    bool flag = false;
                    foreach (var appliance in setType.appliances)
                    {
                        if (appliance.type.ToLower() == searchType) 
                        {
                            Console.WriteLine(appliance.ToString());
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine($"No {searchType} appliances found.");
                    }
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
            }
        }
    }
}
