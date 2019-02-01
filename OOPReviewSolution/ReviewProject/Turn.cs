using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProject
{
    public class Turn
    {
        private int _playerOneRoll;
        
        public int PlayerOneRoll
        {
            get
            {
                return _playerOneRoll;
            }
            set
            {
                _playerOneRoll = value;
            }
        }

        public int PlayerTwoRoll { get; set; }
        
        public Turn()
        {

        }

        public Turn(int playerTwo, int playerOne)
        {
            PlayerOneRoll = playerOne;
            PlayerTwoRoll = playerTwo;
        }

        //methods
        //public string FindRollResults()
        //{
        //  return winner;
        //}
    }
}
