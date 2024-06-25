using OOP2GroupLab1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class TextToList
    {
        // Constructor
        public TextToList() { }
        public List<string[]> TextIterator()
        {
            List<string[]> appliance_list = new List<string[]>();

            // Iterate over text file
            string text = Resources.appliances;
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                string[] attributes = line.Split(';');
                appliance_list.Add(attributes);
            }

            // Returns = List of Strings
            // Format = appliance_list[item in list][attribute]
            return appliance_list;
        }
    }
}
