using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingArea
{
    class Program
    {
        public static int ShowMenu(string arrow1, string arrow2, int options, string welcomemsg = "", string arrowstousemsg = "", string opt1 = "", string opt2 = "", string opt3 = "", string opt4 = "", string opt5 = "", string opt6 = "")
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (welcomemsg == "")
            {

            }
            else
            {
                Console.WriteLine($"{welcomemsg}");
            }
            Console.ResetColor();
            if (arrowstousemsg == "")
            {

            }
            else
            {
                Console.WriteLine($"{arrowstousemsg}");
            }
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = $"✅ \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                if (arrow1 == "LeftArrow" && arrow2 == "RightArrow")
                {
                    if (!(opt1 == null) || !(opt1 == ""))
                    {
                        Console.Write($"{(option == 1 ? decorator : "  ")}{opt1}\u001b[0m");
                    }
                    if (!(opt2 == null) || !(opt2 == ""))
                    {
                        Console.Write($"{(option == 2 ? decorator : "  ")}{opt2}\u001b[0m");
                    }
                    if (!(opt3 == null) || !(opt3 == ""))
                    {
                        Console.Write($"{(option == 3 ? decorator : "  ")}{opt3}\u001b[0m");
                    }
                    if (!(opt4 == null) || !(opt4 == ""))
                    {
                        Console.Write($"{(option == 4 ? decorator : "  ")}{opt4}\u001b[0m");
                    }
                    if (!(opt5 == null) || !(opt5 == ""))
                    {
                        Console.Write($"{(option == 5 ? decorator : "  ")}{opt5}\u001b[0m");
                    }
                    if (!(opt6 == null) || !(opt6 == ""))
                    {
                        Console.Write($"{(option == 6 ? decorator : "  ")}{opt6}\u001b[0m");
                    }
                }
                else if (arrow1 == "UpArrow" && arrow2 == "DownArrow")
                {
                    if (!(opt1 == null) || !(opt1 == ""))
                    {
                        Console.WriteLine($"{(option == 1 ? decorator : "  ")}{opt1}\u001b[0m");
                    }
                    if (!(opt2 == null) || !(opt2 == ""))
                    {
                        Console.WriteLine($"{(option == 2 ? decorator : "  ")}{opt2}\u001b[0m");
                    }
                    if (!(opt3 == null) || !(opt3 == ""))
                    {
                        Console.WriteLine($"{(option == 3 ? decorator : "  ")}{opt3}\u001b[0m");
                    }
                    if (!(opt4 == null) || !(opt4 == ""))
                    {
                        Console.WriteLine($"{(option == 4 ? decorator : "  ")}{opt4}\u001b[0m");
                    }
                    if (!(opt5 == null) || !(opt5 == ""))
                    {
                        Console.WriteLine($"{(option == 5 ? decorator : "  ")}{opt5}\u001b[0m");
                    }
                    if (!(opt6 == null) || !(opt6 == ""))
                    {
                        Console.WriteLine($"{(option == 6 ? decorator : "  ")}{opt6}\u001b[0m");
                    }
                }
                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (arrow1 == "UpArrow")
                        {
                            option = option == 1 ? options : option - 1;
                        }
                        else
                        {
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (arrow2 == "DownArrow")
                        {
                            option = option == options ? 1 : option + 1;
                        }
                        else
                        {
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (arrow1 == "LeftArrow")
                        {
                            option = option == 1 ? options : option - 1;
                        }
                        else
                        {
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (arrow2 == "RightArrow")
                        {
                            option = option == options ? 1 : option + 1;
                        }
                        else
                        {
                        }
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }
            Console.WriteLine($"\n{decorator}You selected Option {option}");
            Console.ResetColor();
            return option;
        }
    }
}
