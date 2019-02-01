using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProject
{
    public class Die
    {
        //Create a new instance of the math class Random
        //This instance (occurance, object) will be shared by each instance of the class Die
        //This instance will be created when the first instance of Die is created
        private static Random _rnd = new Random();

        //this is the definition of a object
        //it is a conceptual view of the data
        //that will be held by a physical 
        //instance (object) of this class

        //Components of an object

        //Date Members
        //is an internal private date storage item
        //private data memebers CANNOT be reached directly by the user
        //public data memebers CAN be reached directly by the user
        private int _Side;
        private string _Color;
        //private int _FaceValue;

        //Properties
        //A property is an external interface between the user and a single piece of data within the instance
        //A property has two ability
        // a) the ability to assign a value to the internal data member
        // b) return a internal data memeber value to the user

        //Fully Implemented Property
        public int Side
        {
            get
            {
                //takes internal values and returns it to the user
                return _Side;
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

        //Optional: if not supplied the system default constructor is used which will assign a value to each data member/auto implemented property according to its data type.
        //You can have any number of contructors within your class as soon as you code a contructor, your program is responsible for all constructors

        //sytanx of a constructor: public classmate([list of prameters]) {...}

        //Typical Constructors
        //Default Constructors
        //This is similar to the system default contructor
        public Die()
        {
            //You could leave this constructor empty and the system would acess the normal default value to your data member
            //You can directly access a private data member in any place within your class
            _Side = 6;
            //You can access any property any place within your class
            _Color = "White";

            //You could use a class method to generate a value for a data member/auto property
            Roll();
        }

        //Greedy Constructor
        //Typically has a parameter for each data member and auto implemented property within your class
        //parameter order is not important
        //This constructor allows the outside user to create and assign their own values to the data member/auto properties at the time of instance creation
        public Die(int sides, string color)
        {
            //Since this data is coming from an outside source it is best to use your property to save the value, specially if the property has validation
            Side = sides;
            Color = color;
            Roll();
        }


        //Behaviours (methods)
        //These are actions that the class can perform
        //The actions may or may not alter data members/auto values
        //The actions could simply take a value(s) from the user and perform some logic operations against the values

        //Can be public or private
        //Create a method that allows the user to change the number of sides on a die
        public void SetSides(int sides)
        {
            if (sides >= 6 && sides <= 20)
            {
                Side = sides;
            }
            else
            {
                //Optionally 
                //a) throw a new exception
                throw new Exception("Invalid value for sides");
                //b) set _Sides to a default value
                //Side = 6;
            }
            Roll();
        }

        public void Roll()
        {
            //No parameters are required for this method since it will be using the internal data values to complete its functions 

            //Randomly generate a value for the die depending on the maximum sides
            FaceValue = _rnd.Next(1, Side + 1);
        }
    }
}
