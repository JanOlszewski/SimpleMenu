using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] mItems = { "1: Addition", "2: Subtraction", "3: Multiplication", "4: Division", "5: EXIT" };

            ConsoleMenu mainMenu = new ConsoleMenu(mItems, 0, 0, ConsoleColor.DarkYellow, ConsoleColor.Blue);
            SimpleCalculator calc = new SimpleCalculator();

            Boolean b = true;
            int choice;

            while (b == true)
            {
                choice = mainMenu.showMenu();
                switch(choice)
                {
                    case 0:
                        Console.WriteLine(calc.addition());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine(calc.subtraction());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(calc.multiplication());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine(calc.division());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        b = false;
                        break;
                }
            }
            
        }
    }
}
