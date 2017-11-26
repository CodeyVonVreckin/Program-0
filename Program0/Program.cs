/*
Grading ID: C4811
CIS 200-01
Due Date: 9/22/16
This program demonstrates the HAS-A and IS-A relationships between Classes. Then creates objects from those classes,
adds them to a list, and then displays them on the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program
    {   //Precondition: Requires that you give a Name(string), Address1(string), Address2(string), 
        //              City(string), State(string) and Zip Code(int)      
        //Postcondition: Displays the Letters and all their associated information
        static void Main(string[] args)
        {
            const decimal FIXED_COST = 1.5M; // declares a constant decimal variable to hold the Fixed Cost of Letters
            
            // creates 4 new Address objects with Name, Address 1 and 2, City, State, Zip Code
            Address address1 = new Address("Stan Marsh", "ShTapa Town", "4321 Your Street", "South Park", "Colorado", 60009);
            Address address2 = new Address("Eric Cartman", "South Park Elementary", "Detention Room 102", "South Park", "Colorado", 60009);
            Address address3 = new Address("Kenny McCormick", "SoDoSoapa", "1111 Gheto Avenue", "South Park", "Colorado", 60009);
            Address address4 = new Address("Kyle Broflovski", "The Church of God", "5676 Jewish Lane", "South Park", "Colorado", 60009);

            
            Letter letter1 = new Letter(address1, address2, FIXED_COST);
            Letter letter2 = new Letter(address3, address1, FIXED_COST);    // creates 3 new letter objects
            Letter letter3 = new Letter(address4, address3, FIXED_COST);

            // creates a List of Parcels
            List<Parcel> letters = new List<Parcel>();

            letters.Add(letter1);
            letters.Add(letter2);  // Adds the 3 created letter objects into the List
            letters.Add(letter3);

            // displays a header for the list of letters
            Console.WriteLine("List of Letters");
            Console.Write("---------------");

            // displays the 3 letter objects from the List
            // for (int i = 0; i < letters.Count; i++)
            // Console.WriteLine($"\nLetter {letters[i]}");
            foreach (Parcel p in letters)
                Console.WriteLine($"{p.ToString()}");
        }
    }
}
