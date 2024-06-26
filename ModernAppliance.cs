using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class ModernAppliance : Appliance
    {
        public override void Checkout()
        {
            TextToList getList = new TextToList();
            List<string[]> appliance_list1 = getList.TextIterator();

            List<string> itemNumber = new List<string>();

            foreach (string[] s in appliance_list1)
            {
                itemNumber.Add(s[0]);
            }
            string searchNumber = Console.ReadLine();


            if (itemNumber.Contains(searchNumber) == false)
            {
                Console.WriteLine("\nNo appliances found with that item number.");
            }
            else if (itemNumber.Contains(searchNumber))
            {
                for (int i = 0; i < appliance_list1.Count; i++)
                {

                    if (int.Parse(appliance_list1[i][0]) == int.Parse(searchNumber))
                    {
                        if (IsAvailable() == true)
                        {
                            Console.WriteLine($"\nAppliance \"{searchNumber}\" has been checked out.");
                        }
                        else
                        {
                            Console.WriteLine($"\nThe appliance \"{searchNumber}\" is not available to be checked out.");
                        }
                    }
                }

            }

        }
    }
}