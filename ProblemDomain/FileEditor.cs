using OOP2GroupLab1.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class FileEditor
    {
        // Constructor
        public FileEditor() { }

        //Methods

        // Turns the appliances.txt file into a list of strings
        public List<string[]> LoadText()
        {
            List<string[]> applianceList = new List<string[]>();

            // Iterate over text file
            string text = Resources.appliances;
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                string[] attributes = line.Split(';');
                applianceList.Add(attributes);
            }

            // Returns = List of Strings
            // Format = applianceList[item in list][attribute]
            return applianceList;
        }

        // Saves an updated appliances.txt file
        public void SaveText(List<Appliance> appliances)
        {
            string text = ""; // String to be updated with each appliance


            int index = 0;
            foreach (Appliance appliance in appliances)
            {
                List<string> values = new List<string>(); // Holds values to be added into the text string
                string textToAdd;

                // Shared attributes
                values.Add(appliances[index].itemNumber.ToString());
                values.Add(appliances[index].brand);
                values.Add(appliances[index].quantity.ToString());
                values.Add(appliances[index].wattage.ToString());
                values.Add(appliances[index].colour);
                values.Add(appliances[index].price.ToString());

                // Type specific attributes
                if (appliance is Refrigerator refrigerator)
                {
                    values.Add(refrigerator.doors.ToString());
                    values.Add(refrigerator.height.ToString());
                    values.Add(refrigerator.width.ToString());
                }
                else if (appliance is Vacuum vacuum)
                {
                    values.Add(vacuum.grade);
                    values.Add(vacuum.batteryVoltage.ToString());
                }
                else if (appliance is Microwave microwave)
                {
                    values.Add(microwave.capacity.ToString());
                    values.Add(microwave.roomType.ToString());
                }
                else if (appliance is Dishwasher dishwasher)
                {
                    values.Add(dishwasher.feature);
                    values.Add(dishwasher.soundRating);
                }
                // Updates text string with appliance information seperated by ';'
                textToAdd = String.Join(";", values);
                text = text + "\n" + textToAdd;

                index++;
            }

            // Saves appliances.txt file path relative to the program
            string filePath = @"..\..\Resources\appliances.txt";
            // Overwrites appliances.txt with updated appliance information
            File.WriteAllText(filePath, text);
        }
    }
}