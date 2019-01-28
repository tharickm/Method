/*
    Author: Tharick Moulton
    Date: 1/28/2019
    Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user. 
*/






using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            // This variable will gather data from user input

            string Username = Console.ReadLine();
           // Stores user input as sting called "Username"
            
           
            Console.WriteLine("Hello " + Username + "!");
            // Displays users input back to screen
            Console.WriteLine("Press any key to exit the program and try again ...");
            Console.ReadKey(true);

        }//End of main

    }// End of class

}// End of namespace
