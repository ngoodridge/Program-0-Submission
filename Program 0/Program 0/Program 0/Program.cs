//Grading ID: D7184
//Program 0
//Due: 9/10/2018
//CIS 200-01

//This class is a consoloe appication that displa the origin and destination addresses, as well as the cost of shipping.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test code that declares a new address and provides hard coded test data
            Address Address1 = new Address("Nicholas Goodridge", "1234 1st Street", "Apt #207", "Louisville", "KY", 01234);
            Address Address2 = new Address("Derrek Baxter", "5678 2nd Street", "Cinncinatti", "OH", 67890);
            Address Address3 = new Address("Eric Hoeweler", "0987 3rd Street", "Chicago", "IL", 45678);
            Address Address4 = new Address("Lynnzee Kazee", "6543 4th Street", "Apt #456", "Panama", "KY", 10293);


            //Test code that declares a new letter and provides hard coded test data
            Letter Letter1 = new Letter(Address1, Address2, 10);
            Letter Letter2 = new Letter(Address3, Address4, 30);
            Letter Letter3 = new Letter(Address1, Address4, 20);

            var Parcels = new List<Parcel> { Letter1, Letter2, Letter3 }; //Creates a list and fills it with the letters

            //Prints the contentes of the Parcels list to the console
            foreach(var Letter in Parcels)
            {
                Console.WriteLine(Letter.ToString());
            }
        }
    }
}
