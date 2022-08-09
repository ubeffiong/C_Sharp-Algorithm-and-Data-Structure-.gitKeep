using System;
using System.Collections;
using System.Collections.Generic;

namespace StockValue_Assignment_6
{
    class Program
    {
        public static void UpdateValue(Hashtable stocHashTable)
        {
            int i = 0;
            Console.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-\t   -DATE-");
            foreach (DictionaryEntry item in stocHashTable)
                Console.WriteLine($"\t[{i++}]:\t{item.Key}\t{item.Value}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Hashtable stockHashTable = new Hashtable();
         
            Console.WriteLine("Entry enter value for item key 1");
            stockHashTable[1] = (Console.ReadLine(), DateTime.Today.AddDays(-20));
            Console.WriteLine("Entry enter value for item key 2");
            stockHashTable[2] = (Console.ReadLine(), DateTime.Today.AddDays(-12));
            Console.WriteLine("Entry enter value for item key 3");
            stockHashTable[3] = (Console.ReadLine(), DateTime.Today.AddDays(-10));
            Console.WriteLine("Entry enter value for item key 4");
            stockHashTable[4] = (Console.ReadLine(), DateTime.Now);
            Console.WriteLine("Entry enter value for item key 5");
            stockHashTable[5] = (Console.ReadLine(), DateTime.Now);

            // Displays the values of the Hashtable.
            Console.WriteLine("The current Stock contains the following items and values:");
            UpdateValue(stockHashTable);

            try
            {
                // update value on hashtable
                for (int i = 0; i < 2; i++)
                {
                    int myKey;
                    Console.WriteLine("Update at least 2 entries - Entry Key to update value");
                    string myKey1 = (Console.ReadLine());
                    myKey = Convert.ToInt32(myKey1);
                    Console.WriteLine("Entry Value");
                    var valueT = (Console.ReadLine(),    DateTime.Now);
                
                    //Searches if specific key exist.
                    if (stockHashTable.ContainsKey(myKey))
                    {
                        Console.WriteLine("The key \"{0}\" is {1}.", myKey, stockHashTable.ContainsKey(myKey) ? 
                            "an item and stock has been updated" : "NOT an item and will be added");
                        //stockHashTable.Remove(myKey);
                        stockHashTable[myKey] = (valueT);                      
                    }
                    else
                    {
                        Console.WriteLine("New Addtion");
                        stockHashTable.Add(myKey, valueT);
                        //UpdateValue(stockHashTable);
                    }
                }
                Console.WriteLine("The Hashtable contains the following values:");
                UpdateValue(stockHashTable);

                foreach (DictionaryEntry item in stockHashTable)
                    if (item.Value is DateTime)
                    {
                        stockHashTable.Remove(item);
                    }                   
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to handle changes");
            }
            //foreach (DictionaryEntry item in stockHashTable)
                //Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);            
        }
       
    }

}
