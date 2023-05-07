using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now; 

            string hh = dt.ToString("hh:mm:ss tt"); //12 HOUR FORMAT
            string HH = dt.AddHours(1).ToString("HH:mm:ss");    //24 HOUR FORMAT 
            Console.WriteLine("Time1 =: " + hh);
            Console.WriteLine("Time2 =: " + HH);

            //String strT12 = "07:45:00PM";
            Console.Write("\nTime1 in 24 hour format is: ");
            in24Hours(hh); Console.WriteLine("");

            //String strT24 = "17:45:00";
            Console.Write("\nTime2 in 12 hour format is: ");
            in12Hours(HH); Console.WriteLine("");
        }
        static void in24Hours(String hh)
        { // Covert hours to int
            int h1 = (int)hh[1] - '0'; // assign first digit of hour to a variable
            int h2 = (int)hh[0] - '0'; // assign second digit of hour to a variable
            int hour = (h2 * 10 + h1 % 10); //make hour as an integer value
          
            if (hh[8] == 'A')
            { // for "AM"
                if (hour == 12)
                { //12 is 00 in 24-hour
                    Console.Write("00");
                    //Printing min and sec Staring from position 3
                    for (int i = 2; i <= 7; i++)
                        Console.Write(hh[i]);
                }
                else
                { //Printing min and sec Staring from position 3
                    for (int i = 0; i <= 7; i++)
                        Console.Write(hh[i]);
                }
            }     
            else
            {  // for "PM"
                if (hour == 12)
                { //12 is 12 in 24-hour
                    Console.Write("12");
                    //Printing min and sec Staring from position 3
                    for (int i = 2; i <= 7; i++)
                        Console.Write(hh[i]);
                }
                else
                { //add 12 to int hour
                    hour = hour + 12;
                    Console.Write(hour);
                    //Printing min and sec Staring from position 3
                    for (int i = 2; i <= 7; i++)
                        Console.Write(hh[i]);
                }
            }
        }
        static void in12Hours(string HH)
        {   //Covert hours to int
            int h1 = (int)HH[1] - '0';
            int h2 = (int)HH[0] - '0';
            int hour = (h2 * 10 + h1 % 10);

            // Make the AM or PM array 
            char[] setMeridiem = new char[2]; 

            if (hour < 12)
            { //less than 12 hour it is AM  
                setMeridiem[0] = 'A';
                setMeridiem[1] = 'M';
            }
            else
            { //greater that 12 hour it is PM 
                setMeridiem[0] = 'P';
                setMeridiem[1] = 'M';
            }

            hour %= 12; // Calculating in 12 hour 
  
            if (hour == 0)
            {  //00 in 24-hour is 12 in 12-hour
                Console.Write("12");   
                // Printing minutes and seconds  
                for (int i = 2; i < 8; ++i)
                    Console.Write(HH[i]);
            }
            else
            {
                Console.Write(hour);
                // Printing minutes and seconds  
                for (int i = 2; i < 8; ++i)
                    Console.Write(HH[i]);
            }
            // Add Am or Pm  
            Console.Write(" {0}{1}", setMeridiem[0], setMeridiem[1]);
        }

    }
}
