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
        //private int _FaceValue;

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
                //optionally you may place validation on the incoming value
                if (value >= 6 && value <= 20)
                {
                    _Size = value;
                }
                else
                {
                    throw new Exception("Die cannot be " + value.ToString() + " sides. Die must have between 6 and 20 sides.");
                }
            }
        }
        //Auto Implemented Property
        //Public, it has a datatype, it has a name, IT does not have an internal data member that you can DIRECTLY access.
        //The system will create, internally, a data storage area of the appropriate datatype and manage the area.
        //The only way to access the data of an Auto Implemented Property is via the property, usually used when their is no need for any internal validation or other property logics.
        public int FaceValue { get; set; }

        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                // (value == null) this will fail for an empty string
                // (value == "") this will fail for a null value
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("The color field cannot be blank");
                }
                else
                {
                    _Color = value;
                }
            }
        }

        //Constructors

        //Behaviours (methods)
    }
}
