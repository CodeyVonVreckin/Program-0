using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        /* declares the backing fields to hold the Name, Address1,
           Address2, City, State,  and Zip                      */
        private int _zipCode; 
        private string _name; 
        private string _address1; 
        private string _address2; 
        private string _city; 
        private string _state; 

        // declares a constant variables to hold the Max and Min Zip Codes
        const int MAX_ZIPCODE = 99999; 
        const int MIN_ZIPCODE = 00000; 

        // constructor for the Address Class 
        public Address(string n, string a1, string a2, string c, string s, int zip)
        {
            Name = n; 
            Address1 = a1;
            Address2 = a2;     // declares the Name, Address1, Address2, City, State, and Zip Properties
            City = c;
            State = s;
            Zip = zip;
        }
        public int Zip // declares the Zip Property
        {
            //Precondition: None
            //Postcondition:returns zip
            get { return _zipCode; }
            //Precondition: 00000 <= value <= 99999
            //Postcondition:the zip is set to the specified value
            set
            {
                // if value meeets the requirements then the entered Zip is made the value
                if (value >= MIN_ZIPCODE && value <= MAX_ZIPCODE)
                    _zipCode = value;
                else
                    // if not, then an out of range execption is thrown
                    throw new ArgumentOutOfRangeException("Zip Code",
                        value, "Zip Code out of range between 00000-99999");
            }
        }

        public string Name // declares the Name Property
        {
            //Precondition: None
            //Postcondition:returns name
            get { return _name; }
            //Precondition: None
            //Postcondition:the name is set to the specified value
            set { _name = value; }
        }

        public string Address1 // declares the Address1 Property
        {
            //Precondition: None
            //Postcondition:returns address1
            get { return _address1; }
            //Precondition: None
            //Postcondition:the address1 is set to the specified value
            set { _address1 = value; }
        }

        public string Address2 // declares the Address2 Property
        {
            //Precondition: None
            //Postcondition:returns address2
            get { return _address2; }
            //Precondition: None
            //Postcondition:the address2 is set to the specified value
            set { _address2 = value; }
        }

        public string City // declares the City Property
        {
            //Precondition: None
            //Postcondition:returns city
            get { return _city; }
            //Precondition: None
            //Postcondition:the city is set to the specified value
            set { _city = value; }
        }

        public string State // declares the State Property
        {
            //Precondition: None
            //Postcondition:returns state
            get { return _state; }
            //Precondition: None
            //Postcondition:the state is set to the specified value
            set { _state = value; }
        }
        //Precondition: None
        //Postcondition: a string is returned in a new format
        public override string ToString() 
        {
            return $"{Name}\n{Address1} \n{Address2} \n{City}, {State} {Zip}" + System.Environment.NewLine;
        }
    }
}

