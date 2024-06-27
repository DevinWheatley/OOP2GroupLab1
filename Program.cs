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
                        if (searchNumber == setType.appliances[index].itemNumber && setType.appliances[index].quantity > 0)
                        {
                            Console.WriteLine($"\nAppliance \"{searchNumber}\" has been checked out.\n");
                            // Update quantity
                            setType.appliances[index].quantity--;
                            flag = true;
                        }
                        else if (searchNumber == setType.appliances[index].itemNumber && setType.appliances[index].quantity <= 0)
                        {
                            Console.WriteLine("\nThe appliance is not available to be checked out.\n");
                            flag = true;
                        }
                        index++;
                    }
                    
                    // if no matching Item Number found
                    if (flag == false) 
                    { Console.WriteLine($"\nNo appliances found with that item number.\n"); }
                }
                
                /*else if (choice == 2) // Find by brand
                {
                    // Define Brand to be searched for
                    Console.Write("Enter brand to search for : ");
                    string searchBrand = Console.ReadLine();

                    // Iterate over each appliance checking for brand name
                    bool flag = false; // flag will trigger true if an appliance with a matching brand is found
                    foreach (Appliance appliance in setType.appliances)
                    {
                        if (searchBrand.ToLower() == brand.ToLower())
                        {
                            // Run ToString method for appliance
                            Console.WriteLine(appliance.ToString());
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

                    if (typeChoice == 1)
                    {
                        foreach (var appliance in setType.refrigerators)
                        {
                            Console.WriteLine(appliance.ToString());
                        }
                    }
                    else if (typeChoice == 2)
                    {
                        foreach (var appliance in setType.vacuums)
                        {
                            Console.WriteLine(appliance.ToString());
                        }
                    }
                    else if (typeChoice == 3)
                    {
                        foreach (var appliance in setType.microwaves)
                        {
                            Console.WriteLine(appliance.ToString());
                        }
                    }
                    else if (typeChoice == 4)
                    {
                        foreach (var appliance in setType.dishwashers)
                        {
                            Console.WriteLine(appliance.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid type selected.");
                    }
                }
            
                else if (choice == 4) // Random
                {
                    // List containing indexs of chosen appliances in appliances list
                    List<int> randNums = new List<int>();

                    // Instantiate the built in Random class
                    Random random = new Random();

                    // Define amount of appliances to be shown
                    Console.Write("Enter number of appliances : ");
                    int randAmount = int.Parse(Console.ReadLine());
                    Console.Write("\nRandom Appliances :");

                    while (randNums.Count < randAmount)
                    {
                        // Sets a random number to be indexed
                        int randAdd = random.Next(0, setType.appliances.Count);
                        // Checks that the index isn't already added
                        if (!randNums.Contains(randAdd))
                        {
                            randNums.Add(randAdd);
                        }  
                    }

                    // Display information for (randAmound) of appliances
                    foreach (int num in randNums)
                    {
                        Console.WriteLine(setType.appliances[num].ToString());
                    }
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
