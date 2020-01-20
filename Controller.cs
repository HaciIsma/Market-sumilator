using System;
using System.Threading;

namespace Market
{
    class Controller
    {
        static void tableVariables(ref Manager manager)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(12, 18);
            Console.Write(manager.vegetables.potato.Prestige);
            Console.SetCursorPosition(22, 18);
            Console.Write(manager.vegetables.tomato.Prestige);
            Console.SetCursorPosition(32, 18);
            Console.Write(manager.vegetables.onion.Prestige);
            Console.SetCursorPosition(42, 18);
            Console.Write(manager.vegetables.cucumber.Prestige);
            Console.SetCursorPosition(52, 18);
            Console.Write(manager.vegetables.pepper.Prestige);

            Console.SetCursorPosition(12, 19);
            Console.Write(manager.vegetables.potato.Health);
            Console.SetCursorPosition(22, 19);
            Console.Write(manager.vegetables.tomato.Health);
            Console.SetCursorPosition(32, 19);
            Console.Write(manager.vegetables.onion.Health);
            Console.SetCursorPosition(42, 19);
            Console.Write(manager.vegetables.cucumber.Health);
            Console.SetCursorPosition(52, 19);
            Console.Write(manager.vegetables.pepper.Health);

            Console.SetCursorPosition(12, 20);
            Console.Write(manager.marketManager.market.potatoBox);
            Console.SetCursorPosition(22, 20);
            Console.Write(manager.marketManager.market.tomatoBox);
            Console.SetCursorPosition(32, 20);
            Console.Write(manager.marketManager.market.onionBox);
            Console.SetCursorPosition(42, 20);
            Console.Write(manager.marketManager.market.cucumberBox);
            Console.SetCursorPosition(52, 20);
            Console.Write(manager.marketManager.market.pepperBox);

            Console.SetCursorPosition(12, 21);
            Console.Write(manager.vegetables.potato.Quantity);
            Console.SetCursorPosition(22, 21);
            Console.Write(manager.vegetables.tomato.Quantity);
            Console.SetCursorPosition(32, 21);
            Console.Write(manager.vegetables.onion.Quantity);
            Console.SetCursorPosition(42, 21);
            Console.Write(manager.vegetables.cucumber.Quantity);
            Console.SetCursorPosition(52, 21);
            Console.Write(manager.vegetables.pepper.Quantity);
        }

        static void pinTable(ref Manager manager)
        {

            for (int i = 0; i < 75; i++)
            {
                Console.Write('-');
            }
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 51; j = j + 10)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write('|');
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 51; i++)
            {
                Console.Write('-');
            }
            for (int i = 0; i < 19; i++)
            {
                Console.SetCursorPosition(0, 5 + i);
                Console.Write('|');

            }
            for (int i = 0; i < 9; i++)
            {

                Console.SetCursorPosition(50, 5 + i);
                Console.Write('|');
            }
            Console.SetCursorPosition(0, 14);
            for (int i = 0; i < 75; i++)
            {
                Console.Write('-');
            }
            for (int i = 1; i < 14; i++)
            {
                Console.SetCursorPosition(74, i);
                Console.Write('|');
            }
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(0, i + 15);
                Console.Write('|');
                Console.SetCursorPosition(74, i + 15);
                Console.Write('|');
            }
            Console.SetCursorPosition(0, 23);
            for (int i = 0; i < 75; i++)
            {
                Console.Write('-');
            }
            Console.SetCursorPosition(1, 15);
            for (int i = 0; i < 73; i++)
            {
                Console.Write('-');
            }
            Console.SetCursorPosition(1, 22);
            for (int i = 0; i < 73; i++)
            {
                Console.Write('-');
            }

            for (int i = 16; i < 22; i++)
            {
                for (int j = 1; j < 62; j = j + 10)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write('|');
                }
            }
            for (int j = 0; j < 6; j++)
            {
                Console.SetCursorPosition(73, j + 16);
                Console.Write('|');
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            Console.Write("Rating:");
            Console.SetCursorPosition(11, 1);
            Console.Write("Employee:");
            Console.SetCursorPosition(21, 1);
            Console.Write("Money:");
            Console.SetCursorPosition(31, 1);
            Console.Write("Storage:");
            Console.SetCursorPosition(41, 1);
            Console.Write("StartStop");


            Console.SetCursorPosition(12, 16);
            Console.Write("Potato:");
            Console.SetCursorPosition(22, 16);
            Console.Write("Tomato:");
            Console.SetCursorPosition(32, 16);
            Console.Write("Onion:");
            Console.SetCursorPosition(42, 16);
            Console.Write("Cucumber:");
            Console.SetCursorPosition(52, 16);
            Console.Write("Pepper:");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(2, 18);
            Console.Write("Rating ->");
            Console.SetCursorPosition(2, 19);
            Console.Write("Health ->");
            Console.SetCursorPosition(2, 20);
            Console.Write("Storage->");
            Console.SetCursorPosition(2, 21);
            Console.Write("amount ->");

            tableVariables(ref manager);

        }

        public void Control()
        {
            Time time = new Time();
            Manager manager = new Manager();
            pinTable(ref manager);
            Thread t = new Thread(new ThreadStart(time.Clock));
            t.Start();
        }
    }
}
