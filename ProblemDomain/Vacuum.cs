using OOP2GroupLab1.ProblemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2GroupLab1.ProblemDomain
{
    internal class Vacuum : Appliance
    {
        // --- Attributes --- 
        private int _batteryVoltage;
        private string _grade;
        // --- Getters & Setters --- 
        public int batteryVoltage
        { get { return _batteryVoltage; } set { _batteryVoltage = value; } }
        public string grade
        { get { return _grade; } set { _grade = value; } }
        // --- Constructor --- 
        public Vacuum(int itemNumber, string brand, int quantity, int wattage, float price, string colour, int batteryVoltage, string grade)
            : base(itemNumber, brand, quantity, wattage, price, colour)
        {
            this._batteryVoltage = batteryVoltage;
            this._grade = grade;
        }
        // --- Methods ---
        // ToString
        public override string ToString()
        {
            return base.ToString() +
                $"Battery Voltage : {batteryVoltage}V\n" +
                $"Grade : {grade}\n";
        }
    }
}
