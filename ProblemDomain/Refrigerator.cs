using OOP2GroupLab1.ProblemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class Refrigerator : Appliance
    {
        // --- Attributes --- 
        private int _doors;
        private int _height;
        private int _width;
        // --- Getters & Setters --- 
        public int doors
        { get { return _doors; } set { _doors = value; } }
        public int height
        { get { return _height; } set { _height = value; } }
        public int width
        { get { return _width; } set { _width = value; } }
        // --- Constructor --- 
        public Refrigerator(int itemNumber, string brand, int quantity, int wattage, string colour, float price, int doors, int height, int width)
            : base(itemNumber, brand, quantity, wattage, colour, price)
        {
            this._doors = doors;
            this._height = height;
            this._width = width;
        }
        // --- Methods --- 
        // ToString 
        public override string ToString()
        {
            return base.ToString() +
                $"Doors : {doors}\n" +
                $"Height : {height}\n" +
                $"Width : {width}\n";
        }
    }
}
