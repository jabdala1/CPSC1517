using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProject
{
    public class Die
    {
        //this is the definition of a object
        //it is a conceptual view of the data
        //that will be held by a physical 
        //instance (object) of this class

        //Components of an object

        //Date Members
        //is an internal private date storage item
        //private data memebers CANNOT be reached directly by the user
        //public data memebers CAN be reached directly by the user
        private int _Size;
        private string _Color;
        private int _Face;

        //Properties
        //A property is an external interface between the user and a single piece of data within the instance
        //A property has two ability
        // a) the ability to assign a value to the internal data member
        // b) return a internal data memeber value to the user

        //Fully Implemented Property
        public int Size
        {
            get
            {
                //takes internal values and returns it to the user
                return _Size;
            }
            set
            {
                //takes the supplied user value and place it into the internal private data member
                //the incoming piece of data is place into a special variable that is called: value
                _Size = value;
            }
        }
        //Constructors

        //Behaviours (methods)
    }
}
