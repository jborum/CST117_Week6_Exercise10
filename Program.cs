/*
 * Exercise 10
 * This program was written by Jason Borum
 * Date: April 10, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the location of the file to be read
            string path = "Exercise10.txt";

//Initilize the stream reader
            StreamReader inputFile = File.OpenText(path);
            
            //Create list to store strings
            List<string> singleWords = new List<string>(); 
            List<string> fileText = new List<string>();

            //Create array to separate readline into single words
            string[] tokens;

            //Initilize counter to add the number of words that end with t or e
            int counter = 0;

            //Read files until the end of the file
            while (!inputFile.EndOfStream)
            {
                //Add each line in the text file to a list
                fileText.Add(inputFile.ReadLine());
            }

            //Start foreach loop to separate the individual words
            foreach(string str in fileText)
            {
                //Remove the individual words from the read line
                tokens = str.Split(null);

                //Add all the individual words to the list
                singleWords.AddRange(tokens);
            }

            //Test each word that ends with t or e
            foreach (string str in singleWords)
            {
                // set the string to lowercase and test for t or e. If true add to the counter
                if (str.ToLower().EndsWith("t") || str.ToLower().EndsWith("e"))
                counter++;
            }

            //Send results to the console
            Console.WriteLine(String.Format("There are {0} words that end in 't' or 'e' ", counter));

            //Pause Consonle so user can read the results
            Console.WriteLine("Press any key to exit . . .");

            //Close Console after any key is pressed
            Console.ReadLine();

        } // end of main
    } // end of class
} // end of namespace
