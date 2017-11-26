using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Letter : Parcel // establishes a IS-A relationship between Class Letter and Class Parcel
    {
        private decimal _fixedCost; // declares a backing field for fixed cost

        // constructor for the Letter Claass
        public Letter(Address or, Address des, decimal fixedCost) : base(or, des)
        {
            FixedCost = fixedCost; // declares a Fixed Cost Property
        }
       // creates a fixed cost property
        private decimal FixedCost
        {
            //Precondition: None
            //Postcondition:returns FixedCost
            get { return _fixedCost;}
            //Precondition: value >= 0
            //Postcondition:the FixedCost is set to the specified value
            set
            {
                //if value >= 0 the entered fixed cost will be assigned as the value
                if (value >= 0)
                    _fixedCost = value;
                else
                    // if not then an out of range exception is thrown
                    throw new ArgumentOutOfRangeException(" Fixed Cost ", value, "Fixed Cost must be >= 0");
            }

        }
        //Precondition: None
        //Postcondition: returns the fixed Cost
        public override decimal CalcCost()
        {
            return FixedCost;
        }
        //Precondition: None
        //Postcondition: a string is returned in a new format
        public override string ToString()
        {
            return $"\n{base.ToString()}";
        }
    }

}
