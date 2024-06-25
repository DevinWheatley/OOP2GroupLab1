using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class SetType
    {
        // Create lists to sort appliances
        public List<Appliance> appliances;
        
        public List<Refrigerator> refrigerators;
        public List<Vacuum> vacuums;
        public List<Dishwasher> dishwashers;
        public List<Microwave> microwaves;

        // Constructor
        SetType() { }

        // Methods

        // Set Appliance Type
        public void SetApplianceType()
        {
            TextToList applianceList = new TextToList();
            
            foreach (string[] appliance in applianceList.TextIterator())
            {
                if (appliance[0].StartsWith("1"))
                {
                    Refrigerator refrigerator = new Refrigerator(int.Parse(appliance[0]), appliance[1], int.Parse(appliance[2]), int.Parse(appliance[3]), float.Parse(appliance[4]), appliance[5], int.Parse(appliance[6]), int.Parse(appliance[7]), int.Parse(appliance[8]));
                    refrigerators.Add(refrigerator);
                    appliances.Add(refrigerator);
                }
                else if(appliance[0].StartsWith("2"))
                {
                    Vacuum vacuum = new Vacuum(int.Parse(appliance[0]), appliance[1], int.Parse(appliance[2]), int.Parse(appliance[3]), float.Parse(appliance[4]), appliance[5], int.Parse(appliance[6]), appliance[7]);
                    vacuums.Add(vacuum);
                    appliances.Add(vacuum);
                }
                else if (appliance[0].StartsWith("3"))
                {
                    Microwave microwave = new Microwave(int.Parse(appliance[0]), appliance[1], int.Parse(appliance[2]), int.Parse(appliance[3]), float.Parse(appliance[4]), appliance[5], float.Parse(appliance[6]), char.Parse(appliance[7]));
                    microwaves.Add(microwave);
                    appliances.Add(microwave);
                }
                else if (appliance[0].StartsWith("4") || appliance[0].StartsWith("5"))
                {
                    Dishwasher dishwasher = new Dishwasher(int.Parse(appliance[0]), appliance[1], int.Parse(appliance[2]), int.Parse(appliance[3]), float.Parse(appliance[4]), appliance[5], appliance[6], appliance[7]);
                    dishwashers.Add(dishwasher);
                    appliances.Add(dishwasher);
                }
            }

        }
        
    }
}
