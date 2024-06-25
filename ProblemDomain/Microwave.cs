using OOP2GroupLab1.ProblemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class Microwave : Appliance
    {
        // --- Attributes --- 
        private float _capacity;
        private char _roomType;
        // --- Getters & Setters --- 
        public float capacity
        { get { return _capacity; } set { _capacity = value; } }
        public char roomType
        { get { return _roomType; } set { _roomType = value; } }
        // --- Constructor --- 
        public Microwave(int itemNumber, string brand, int quantity, int wattage, float price, string colour, float capacity, char roomType)
            : base(itemNumber, brand, quantity, wattage, price, colour)
        {
            this._capacity = capacity;
            this._roomType = roomType;
        }
        // --- Methods ---
        // ToString
        public override string ToString()
        {
            return base.ToString() +
                $"Capacity : {capacity}\n" +
                $"Room Type : {roomType}\n";
        }
    }
}
