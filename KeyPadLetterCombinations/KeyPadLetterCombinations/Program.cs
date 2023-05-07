using System;
using System.Collections.Generic;

namespace KeyPadLetterCombinations
{
    internal class Program
    {
        // QUESTIONS: https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
        /*
            Given a string containing digits from 2-9 inclusive, return all possible letter combinations 
            that the number could represent. Return the answer in any order.

            A mapping of digits to letters (just like on the telephone buttons) 
            is given below. Note that 1 does not map to any letters.
         */
        static void Main(string[] args)
        {
            //Prompt the user to enter a phone keypad digit
            Console.WriteLine("Enter a phone keypad digit (2-9): ");
            string input = Console.ReadLine();

            //validate the input
            foreach (char digit in input)
                if (digit < '2' || digit > '9')
                {
                    Console.WriteLine("Invalid input: digit must be between 2 and 9");
                    input = Console.ReadLine();
                    //return;
                }

            LetterCombinations(input);

            //Find all possible combinations of letters from the given digit
            //implementing it in a method

            IList<string> LetterCombinations(string digits)
            {
                if (digits.Length == 0)
                {
                    return new List<string>();
                }
                //define the phone keypad digit and their corresponding letters
                //lets use a dictionary
                Dictionary<char, string> phoneMap = new Dictionary<char, string>()
                {
                    {'2', "abc"},
                    {'3', "def"},
                    {'4', "ghi"},
                    {'5', "jkl"},
                    {'6', "mno"},
                    {'7', "pqrs"},
                    {'8', "tuv"},
                    {'9', "wxyz"}
                };
                var result = new HashSet<string>();
                result.Add(""); //to store the combinations. We start with an empty string in the set to seed the recursive process.
                foreach (char digit in digits) //We then iterate over each digit in the input string.  
                {
                    if (!phoneMap.ContainsKey(digit)) //For each digit, we check if it is a valid key in phoneMap.
                    {
                        return new List<string>(); //If it is not, we return an empty list.
                    }
                    //Otherwise, we create a temporary HashSet<string> named tempSet to store the combinations generated for the current digit.
                    var tempSet = new HashSet<string>();
                    foreach (string str in result) //We iterate over each string in result 
                    {
                        foreach (char c in phoneMap[digit])//and each letter corresponding to the current digit,
                        {
                            tempSet.Add(str + c); //and we add the resulting string to tempSet
                        }
                    }//After iterating over all combinations for the current digit,
                    result = tempSet; //we set result to tempSet so that it contains the combinations generated so far.
                }
                Console.WriteLine("Possible letter combinations for {0}: ", input);
                foreach (string combination in result)
                    Console.WriteLine(combination);

                return new List<string>(result); //Finally, we return a List<string> containing all the elements of result.
            }
        }
    }
}
