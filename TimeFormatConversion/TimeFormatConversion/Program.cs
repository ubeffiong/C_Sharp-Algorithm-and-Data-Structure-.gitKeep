using System;
using System.Reflection;

namespace TimeFormatConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            String strT12 = "07:45:00PM";
            Console.Write("07:45:00PM in 24 hour format is: ");
            in24Hours(strT12);
            Console.WriteLine("");

            String strT24 = "17:45:00";  
            Console.Write("\n17:45:00 in 12 hour format is: ");
            in12Hours(strT24);
            Console.WriteLine("");
        }

        static void in24Hours(String strT12)
        {
            // Get hours
            int h1 = (int)strT12[1] - '0'; // Get the first digit of hour in 12 hour format
            int h2 = (int)strT12[0] - '0'; //Get the second digit of hour in 12 hour format
            int hh = (h2 * 10 + h1 % 10); //Caluclate hour as an integer value in 12 hours format

            // If time is in "AM"
            if (strT12[8] == 'A')
            {
                if (hh == 12) 
                { //Base format as 00 in 24-hour is 12 in 12-hour 
                    Console.Write("00");
                    for (int i = 2; i <= 7; i++)
                        Console.Write(strT12[i]);
                }
                else
                { //convert AM time into 12 - hour format
                    for (int i = 0; i <= 7; i++)
                        Console.Write(strT12[i]);
                }
            }
            // If time is in "PM"
            else
            {
                if (hh == 12)
                { //Base format as 12 in 24-hour is 12 in 12-hour
                    Console.Write("12");
                    for (int i = 2; i <= 7; i++)
                        Console.Write(strT12[i]);
                }
                else
                { //convert PM time into 12 - hour format
                    hh = hh + 12;
                    Console.Write(hh);
                    for (int i = 2; i <= 7; i++)
                        Console.Write(strT12[i]);
                }
            }  
        }
        static void in12Hours (string strT24)
        {
            // Get hours; The '0' converts the string value to an integer
            int h1 = (int)strT24[1] - '0'; // first digit of hour in 24 hour format
            int h2 = (int)strT24[0] - '0'; //second digit of hour in 24 hour format
            int hh = (h2 * 10 + h1 % 10); //Caluclate hour as an integer value in 12 hours format

            // Print in 24 hours
            char[] AntePostMeridiem = new char[2]; // Make the AM or PM array 

            if (hh < 12) //Check if the hh is in 12 hour or 24 hour format using if-else and set the Meridian as AM or PM
            { // If the time is less than 12 hour it is AM  
                AntePostMeridiem[0] = 'A';
                AntePostMeridiem[1] = 'M';
            }
            else
            { // When the time is greater that 12 hour it is PM 
                AntePostMeridiem[0] = 'P';
                AntePostMeridiem[1] = 'M';
            }
            //Modulo hh with 12 and convert the time into 12 - hour format
            hh %= 12; // Calculate the 12 hour time 

            // Handle 00 and 12 case separately  
            if (hh == 0)
            {
                Console.Write("12"); // Base format as 00 in 24-hour is 12 in 12-hour  

                // Printing minutes and seconds  
                for (int i = 2; i < 8; ++i)
                {
                    Console.Write(strT24[i]);
                }
            }
            else
            {
                Console.Write( hh);
                // Printing minutes and seconds  
                for (int i = 2; i < 8; ++i)
                {
                    Console.Write(strT24[i]);
                }
            }
            // Print the meridiem of 12-hour format. 
            Console.Write("{0}{1}", AntePostMeridiem[0], AntePostMeridiem[1]);
        }
    }
    
}
