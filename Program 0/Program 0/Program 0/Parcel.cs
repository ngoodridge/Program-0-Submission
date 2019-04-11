//Grading ID: D7184
//Program 0
//Due: 9/10/2018
//CIS 200-01

//The parcel Base abstract class that intializes Origin and Destination Addresses and the CalcCost method and provides the toString method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class Parcel
    {
        //Pre Condition: none
        //Post Condition: initializes OAddress and DAddress
        public Parcel(Address OAddress, Address DAddress)
        {
            OriginAddress = OAddress;
            DestinationAddress = DAddress;
        }

        //Auto Implemented properties
        public Address OriginAddress { get; set; }
        public Address DestinationAddress { get; set; }

        //Abstract method That is used in the dervied class
        public abstract decimal CalcCost();

        //Pre Condition: none
        //Post Condition: Returns a string with information about a parcel
        public override string ToString()
        {
            return $"Origin Address:\n {OriginAddress} \n"  +
                   $"Destination Address:\n {DestinationAddress} \n" +
                   $"Shipping Cost: {CalcCost():c} \n\n" +
                   "***********************************************\n";
        }
    }

}
