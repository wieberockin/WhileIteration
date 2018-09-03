using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option ");
            Console.WriteLine("(1) Option 1");
            Console.WriteLine("(2) Option 2");
            Console.WriteLine("(3) Exit");
            string results = Console.ReadLine();
            
            if ( results == "1")
            {
                PrintNumbers();
                return true;
            }
            else if(results == "2")
            {
                GuessingGame();
                return true;
            }
            else if( results =="3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers!");
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing Game!");
            Console.ReadLine();
        }

    }
}
