//Grading ID: D7184
//Program 0
//Due: 9/10/2018
//CIS 200-01

//This is the Address class that defines the address object and provides a to string to print the addresses

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Address
    {
        //Backing fields
        private string _name;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private int _zip;

        //Conditions for the zip code
        public const int MIN_ZIP = 00000; 
        public const int MAX_ZIP = 99999; 

        //pre condition: none
        //Post Condition: Initializes the properties PName, PAddress1, PCity, PState, PZip
        public Address(string name, string address1, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
        }


        //pre condition: none
        //Post Condition: Initializes the properties PName, PAddress1, PCity, PState, PZip
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            //properties
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }


        //Pre Condition: There is text for the name, it is not null or white space characters
        //Post Condition: Returns the Name and sets it to the value
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Please enter a name.");
                }
                else
                {
                    _name = value;
                }
            }
        }

        //Pre condition: There is text for the name, it is not null or white space characters
        //Post Condition: Returns the Line 1 of the address and sets it to  the value
        public string Address1
        {
            get
            {
                return _addressLine1;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Please enter an Address  Line 1.");

                }
                else
                {
                    _addressLine1 = value;
                }
            }
        }

        //Pre condition: There is text for the name, it is not null or white space characters
        //Post Condition: Returns the Line 2 of the address and sets it to the value
        public string Address2
        {
            get
            {
                return _addressLine2;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Please enter an Address line 2.");

                }
                else
                {
                    _addressLine2 = value;
                }
            }
        }

        //Pre condition: There is text for the name, it is not null or white space characters
        //Post Condition: Returns the city and sets it to the value
        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Please enter a city.");

                }
                else
                {
                    _city = value;
                }
            }
        }

        //Pre condition: There is text for the name, it is not null or white space characters
        //Post Condition: Returns the state and sets it the value
        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Please enter a state.");

                }
                else
                {
                    _state = value;
                }
            }
        }

        //Pre condition: the zip must be greater than 0 and less than 100000
        //Post Condition: Returns the zip and sets it the value
        public int Zip
        {
            get
            {
                return _zip;

            }

            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                    _zip = value;
                else
                    throw new ArgumentOutOfRangeException("Please enter a 5 digit zip code");

            }
        }

        //Pre Condition: non
        //Post Condition: returns a string with the address information
        public override string ToString()
        {
            if(Address2 == null)
            {
                return $"Name: {Name} \n" +
                       $"Address Line 1: {Address1} \n" +
                       $"City: {City} \n" +
                       $"State: {State} \n" +
                       $"Zip Code: {Zip}\n\n";
            }
            else
            {
               return  $"Name: {Name} \n" +
                       $"Address Line 1: {Address1} \n" +
                       $"Address Line 2 {Address2} \n" +
                       $"City: {City} \n" +
                       $"State: {State} \n" +
                       $"Zip Code: {Zip:D5} \n";
            }
        }
    }

}
