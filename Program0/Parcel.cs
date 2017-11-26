using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        //declares the backing fields to hold the Origin Address, and Destination Address
        private Address _originAddress;
        private Address _destinationAddress;

        // constructor for the Parcel Class
    public Parcel (Address or, Address des)
        {
            // declares the OriginAddress, and DestinationAddress Property
            OriginAddress = or;
            DestinationAddress = des;            
        }

        public Address OriginAddress // declares a Origin Address Property
        {
            //Precondition: None
            //Postcondition:returns OriginAddress
            get { return _originAddress; }
            //Precondition: None
            //Postcondition:the OriginAddress is set to the specified value
            set { _originAddress = value; }
        }
       
        public Address DestinationAddress // declares a Destination Address Property
        {
            //Precondition: None
            //Postcondition:returns DestinationAddress
            get { return _destinationAddress; }
            //Precondition: None
            //Postcondition:the DestinationAddress is set to the specified value
            set { _destinationAddress = value; }
        }

        //Precondition: None
        //Postcondition: returns the fixed Cost
        public abstract decimal CalcCost();

        //Precondition: None
        //Postcondition: a string is returned in a new format
        public override string ToString()
        {
            return $"\nOrigin:\n{OriginAddress}\nDesintation:\n{DestinationAddress}\nCost: {CalcCost():C}";
        }
    }
}
