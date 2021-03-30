using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_14_lock
{
    class combinationlock: Lock
    {
        
        private string combination = "999";

        public combinationlock()
        {

        }

        public void openlock(string inputcombination)
        {
            if(combination == inputcombination)
            {
                locked = false;
            }
        }

        public void changecombination(string newcombination)
        {
            if(locked == false)
            {
                combination = newcombination;
            }      
        }
    }
}
