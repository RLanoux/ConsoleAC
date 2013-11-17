using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            Int32 iWidth = 0;
            Int32 iLength = 0;
            Int32 iHeight = 0;
            Int32 iVolume = 0;
            String sUserResponse = String.Empty;

            //Prompt user to enter the width of the room
            Console.Write("Please enter the width of the room (in feet), then press enter: ");

            //Store his response as a string
            sUserResponse = Console.ReadLine();

            //Convert to an integer and stre as an integer
            try
            {
                iWidth = Convert.ToInt32(sUserResponse);
            }
            catch (Exception e)
            {
                Console.Write("\nError converting width: ");
                Console.WriteLine(e.Message);
                Pause("Program will exit now. Press enter to close this window.");
                return;
            }

            //Prompt user to enter the length of the room
            Console.Write("\nPlease enter the length of the room (in feet), then press enter: ");

            //Store response in a string
            sUserResponse = Console.ReadLine();

            //Convert to an integer and store as an integer
            try
            {
                iLength = Convert.ToInt32(sUserResponse);
            }
            catch (Exception e)
            {
                Console.Write("\nError converting length: ");
                Console.WriteLine(e.Message);
                Pause("Program will exit now. Press enter to close this window.");
                return;
            }

            //Prompt user to enter the height of the room
            Console.Write("\nPlease enter the height of the height of the ceiling (in feet), \nthen press enter: ");

            //Store response in a string
            sUserResponse = Console.ReadLine();

            //Convert to an integer and store as an integer
            try
            {
                iHeight = Convert.ToInt32(sUserResponse);
            }
            catch (Exception e)
            {
                Console.Write("\nError converting height: ");
                Console.WriteLine(e.Message);
                Pause("Program will exit now. Press enter to close this window.");
                return;
            }

            //Multiply the three integers by each other and store as an integer
            iVolume = iWidth * iLength * iHeight;

            //Inform the user of the result
            Console.Write("\nThe volume of the room is: ");
            Console.Write(iVolume.ToString());
            Console.WriteLine(" cubic feet.");
            Pause("Program will now close. Press enter to exit this window.");
        }
        static void Pause(String sMsg)
        {
            Console.WriteLine("\n" + sMsg);
            Console.ReadLine();
        }
    }
}
