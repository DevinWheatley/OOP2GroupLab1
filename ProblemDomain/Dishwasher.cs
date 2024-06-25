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
        public Dishwasher(int itemNumber, string brand, int quantity, int wattage, float price, string colour, string feature, string soundRating)
            : base(itemNumber, brand, quantity, wattage, price, colour)
        {
            this._feature = feature;
            this._soundRating = soundRating;
        }
        // --- Methods ---
        // ToString
        public override string ToString()
        {
            return base.ToString() +
                $"Features : {feature}\n" +
                $"Sound Rating : {soundRating}\n";
        }
    }
}
