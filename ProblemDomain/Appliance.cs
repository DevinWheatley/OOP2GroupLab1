using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal abstract class Appliance
    {
        // --- Attributes --- 
        private int _itemNumber;
        private string _brand;
        private int _quantity;
        private int _wattage;
        private float _price;
        private string _colour;
        // --- Getters & Setters --- 
        public int itemNumber
        { get { return _itemNumber; } set { _itemNumber = value; } }
        public string brand
        { get { return _brand; } set { _brand = value; } }
        public int quantity
        { get { return _quantity; } set { _quantity = value; } }
        public int wattage
        { get { return _wattage; } set { _wattage = value; } }
        public float price
        { get { return _price; } set { _price = value; } }
        public string colour
        { get { return _colour; } set { _colour = value; } }
        // --- Parameterless Constructor --- 
        protected Appliance() { }
        protected Appliance(int itemNumber, string brand, int quantity, int wattage, string colour, float price)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.price = price;
            this.colour = colour;
        }
        // --- Methods ---

        // ToString Base
        public override string ToString()
        {
            return $"Item ID : {itemNumber}\n" +
                $"Brand : {brand}\n" +
                $"Quantity : {quantity}\n" +
                $"Wattage : {wattage}W\n" +
                $"Price : ${price}\n" +
                $"Colour : {colour}\n";
        }
        // IsAvailable
        public bool IsAvailable()
        {
            while (true)
            {
                if (quantity <= 0)
                {
                    return false; // Item out of stock
                }
                else
                {
                    return true; // Item is in stock
                }
            }
        }
    }
}