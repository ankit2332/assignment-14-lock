using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_14_lock
{
    class Lock
    {
        protected bool locked;

        public Lock()
        {
            locked = true;
        }

        public bool IsLocked()
        {
            return locked;
        }

         public void closelock()
        {
            locked = true;
        }

        public void openlock()
        {
            locked = false;
        }
    }
}
