using System;

namespace assignment_14_lock
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Lock locker = new Lock();
                Console.WriteLine(locker.IsLocked());

                combinationlock combinationlocker = new combinationlock();

                string i;
                string newcombination;
                Console.WriteLine("Enter combination:");
                i = Console.ReadLine();
                combinationlocker.openlock(i);
                Console.WriteLine(combinationlocker.IsLocked());
                if (combinationlocker.IsLocked() == false)
                {
                    Console.WriteLine("Make a new combination:");
                    newcombination = Console.ReadLine();
                    combinationlocker.changecombination(newcombination);
                    Console.WriteLine("New combination: " + newcombination);
                }
                else
                {
                    Console.WriteLine("scam, You have to unlock the lock to change the combination"); 
                }
            }
            

        }
    }
}
