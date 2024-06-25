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
    }
}
