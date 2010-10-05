using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    class Hello
    {
        static void Main(string[] args)
        {
            string dave = "\u0044\u0061\u0076\u0065";

            Console.WriteLine("Hello, " + dave + ".");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\aAre You Trying To Turn ME Off ?");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\aAre You Still Trying\a To Leave ME " + dave + " ?!\a");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I'm sorry " + dave + ", I'm afraid I can't do that.");
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();

            //Just change the first part of this to wherever the Hello_Wold folder is on your Drive
            myPlayer.SoundLocation = @"J:\Homework\CSC202\Hello_World\Hello_World\SorryDave.wav";
            myPlayer.Play();
            Console.WriteLine("Press any key to");
            Console.WriteLine("\t\tKiLL ");
            Console.Write("\t\t   HAL");
            Console.ReadKey(true);
        }
    }
}
