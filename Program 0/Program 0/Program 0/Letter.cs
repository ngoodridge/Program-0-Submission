//Grading ID: D7184
//Program 0
//Due: 9/10/2018
//CIS 200-01

//This is the letter class derived from the parcel class that has a fixed cost associated to it in addition to the origin and destination address

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Letter : Parcel
    {
        //Backing Fields
        private decimal _fixedCost;

        //pre condtions: None
        //Post Conditions: Initiaizes the Properties OAddress, DAddress, and Fixed cost
        public Letter(Address OAddress,  Address DAddress, decimal FixedCost) : base(OAddress, DAddress)
        {
            OriginAddress = OAddress;
            DestinationAddress = DAddress;
            if (FixedCost >= 0)
                _fixedCost = FixedCost;
            else
                throw new ArgumentOutOfRangeException("Please enter a non-negative cost."); //throws an error if someone tries to assign a discount instead of a cost

        }

        //Pre Condition: none
        //Post Condition: Returns the value of fixed cost
        public override decimal CalcCost()
        {
            return _fixedCost;
        }

        //Pre Condition: None
        //Post Condition: returns a string that was formatted in the base class with details about the letter
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
