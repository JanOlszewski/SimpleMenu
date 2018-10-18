using System;

public class ConsoleMenu
{
    private String[] menuItems;

    private int column;
    private int row;

    private ConsoleColor indicatorColor;
    private ConsoleColor backgroundColor;




    public ConsoleMenu(String[] menuItems)
    {
        this.menuItems = menuItems;

        this.column = 0;
        this.row = 0;

        this.indicatorColor = ConsoleColor.Black;
        this.backgroundColor = ConsoleColor.Blue;
    }


    public ConsoleMenu(String[] menuItems, int column, int row, ConsoleColor indicatorColor, ConsoleColor backgroundColor)
	{
        this.menuItems = menuItems;

        this.column = column;
        this.row = row;

        this.indicatorColor = indicatorColor;
        this.backgroundColor = backgroundColor;
	}




    public int showMenu()
    {
        int indicator = (menuItems.Length - 1);

        ConsoleKeyInfo selected = new ConsoleKeyInfo();

        while(selected.Key != ConsoleKey.Enter)
        {
            Console.SetCursorPosition(column, row);

            for(int i = 0; i < menuItems.Length; i++)
            {
                Console.CursorLeft = column;

                if (i == indicator) { Console.BackgroundColor = backgroundColor; }
                else { Console.BackgroundColor = indicatorColor; }

                Console.WriteLine(menuItems[i].PadRight(25));
            }

            selected = Console.ReadKey(true);
            if(selected.Key == ConsoleKey.UpArrow)
            {
                if(indicator > 0) { indicator--; }
                else { indicator = (menuItems.Length - 1); }
            }
            else if(selected.Key == ConsoleKey.DownArrow)
            {
                if (indicator < (menuItems.Length - 1)) { indicator++; }
                else { indicator = 0; }
            }

        }
        Console.ResetColor();
        return indicator;
    }
}
