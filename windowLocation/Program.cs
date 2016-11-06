using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = System.Console; // assigned Console. to the letter c as an alias

namespace windowLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            //change background and forground colors
            c.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear(); //.Clear() must be done for color to take effect)
            //set window size and title
            Console.Title = "Windows Formatting!!!";
            //set cursor location
            Console.SetCursorPosition(20, 5);
            Console.Write("Enter a number ");
            double x = Convert.ToDouble(Console.ReadLine());
            //conversions
            int xx = (int)x;
            Console.SetCursorPosition(20, 10);
            Console.Write("Enter another number ");
            double y = Convert.ToDouble(Console.ReadLine());
            double total = x + y;
            Console.SetCursorPosition(20, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total is " + total);
            Console.Beep();
            //print out the time
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            DateTime d = new DateTime(2016, 9, 14);
            Console.WriteLine(d);

            //Column and Formatting
            Console.WriteLine();
            Console.WriteLine("{0,-10}{1,-10}{2,10}", "X", "Y", "TOTAL");
            Console.WriteLine("{0,-10:n2}{1,-10:f2}{2,10:c}", x, y, total);

            //making this program call another program
            System.Diagnostics.Process.Start("notepad.exe"); 
                //you can add a path: (@"c:programs\...\notepad.exe)
                //this starts a new thread so any code below this will continue after notepad has opened...
                //...also notepad will stay open even after this program has closed.

            Console.ReadLine();
        }
    }
}
