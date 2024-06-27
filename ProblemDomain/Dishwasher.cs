using OOP2GroupLab1.ProblemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class Dishwasher : Appliance
    {
        // --- Attributes --- 
        private string _feature;
        private string _soundRating;
        // --- Getters & Setters --- 
        public string feature
        { get { return _feature; } set { _feature = value; } }
        public string soundRating
        { get { return _soundRating; } set { _soundRating = value; } }
        // --- Constructor --- 
        public Dishwasher(int itemNumber, string brand, int quantity, int wattage, string colour, float price, string feature, string soundRating)
            : base(itemNumber, brand, quantity, wattage, colour, price)
        {
            this._feature = feature;
            this._soundRating = soundRating;
        }
        // --- Methods ---
        // ToString
        public override string ToString()
        {
            if (this._soundRating == "Qt")
            {
                return base.ToString() +
                    $"Features : {feature}\n" +
                    $"Sound Rating : Quietest\n";
            }
            else if (this._soundRating == "Qr")
            {
                return base.ToString() +
                    $"Features : {feature}\n" +
                    $"Sound Rating : Quieter\n";
            }
            else if (this._soundRating == "Qu")
            {
                return base.ToString() +
                    $"Features : {feature}\n" +
                    $"Sound Rating : Quiet\n";
            }
            else if (this._soundRating == "M")
            {
                return base.ToString() +
                    $"Features : {feature}\n" +
                    $"Sound Rating : Moderate\n";
            }
            else
            {
                return base.ToString() +
                    $"Features : {feature}\n" +
                    $"Sound Rating : {soundRating}\n";
            }
        }
    }
}
