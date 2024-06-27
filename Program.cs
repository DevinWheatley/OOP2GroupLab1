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

                else if (choice == 2) // Find by brand
                {
                    // Define Brand to be searched for
                    Console.Write("Enter brand to search for : ");
                    string searchBrand = Console.ReadLine();
                    Console.WriteLine();

                    // Iterate over each appliance checking for brand name
                    bool flag = false; // true if an appliance with a matching brand is found
                    bool flag2 = false; // will display once, only if a match is found
                    int index = 0;
                    foreach (Appliance appliance in setType.appliances)
                    {
                        if (searchBrand.ToLower() == setType.appliances[index].brand.ToLower())
                        {
                            if (flag2 == false) { Console.WriteLine("Matching Appliances :\n"); }
                            flag2 = true;

                            // Run ToString method for appliance
                            Console.WriteLine(appliance.ToString());
                            flag = true;
                        }
                        index++;
                    }


                    if (flag == false) // if no appliances found with matching brand
                    {
                        Console.WriteLine($"No {searchBrand} appliances found.");
                    }
                }

                else if (choice == 3) // Find by type
                {
                    
                    Console.WriteLine("Select Appliance Type :");
                    Console.WriteLine("1 – Refrigerators");
                    Console.WriteLine("2 – Vacuums");
                    Console.WriteLine("3 – Microwaves");
                    Console.WriteLine("4 – Dishwashers");
                    Console.Write("Enter type of appliance : ");
                    int typeChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (typeChoice == 1) // Refrigerators
                    {
                        Console.Write("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors) : ");
                        int doors = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nMatching refrigerator :");

                        foreach (var appliance in setType.refrigerators)
                        {
                            if (doors == appliance.doors)
                            { 
                                Console.WriteLine(appliance.ToString());
                            }
                        }
                    }
                    else if (typeChoice == 2) // Vacuums
                    {
                        Console.Write("Enter battery voltage value. 18 V (low) or 24 V (high) : ");
                        int voltage = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nMatching vacuums :");

                        foreach (var appliance in setType.vacuums)
                        {
                            if (voltage == appliance.batteryVoltage)
                            {
                                Console.WriteLine(appliance.ToString());
                            }
                        }
                    }
                    else if (typeChoice == 3) // Microwaves
                    {
                        Console.Write("Room where the microwave will be installed: K (kitchen) or W (work site) : ");
                        char room = char.Parse(Console.ReadLine());
                        Console.WriteLine("\nMatching microwaves :");

                        foreach (var appliance in setType.microwaves)
                        {
                            if (room == appliance.roomType)
                            {
                                Console.WriteLine(appliance.ToString());
                            }
                        }
                    }
                    else if (typeChoice == 4) // Dishwashers
                    {
                        Console.Write("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate) : ");
                        string soundRating = Console.ReadLine();
                        Console.WriteLine("\nMatching dishwashers :");

                        foreach (var appliance in setType.dishwashers)
                        {
                            if (soundRating == appliance.soundRating)
                            {
                                Console.WriteLine(appliance.ToString());
                            }
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
                    FileEditor fileEditor = new FileEditor();

                    fileEditor.SaveText(setType.appliances);
                    Console.WriteLine("File Saved. Goodbye.");
                    Environment.Exit(0);
                }
            
                else
                {
                    Console.WriteLine("Input Invalid. Try Again\n");
                }
            }
        }
    }
}
