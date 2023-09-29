using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;

public class Company
{
	//private string _menu = "MenuFeature.txt";
	private List<string> employees = new List<string>();
	public void runCompanyApp()
	{
        bool runProgram = true;
        do
        {
            int selection = 0;
            bool validChoice = false;
            while (validChoice == false)
            {
                string[] menu = File.ReadAllLines("MenuFeature.txt");
                foreach (string line in menu)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("Please enter your choice: ");
                string choice = Console.ReadLine();

                validChoice = int.TryParse(choice, out selection);
                //Console.WriteLine();
                if (validChoice == false)
                { 
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number");
                    Console.WriteLine();
                }
                else if (validChoice == true && selection <1 || selection > 5)
                {
                    Console.Clear();
                    Console.WriteLine($"You selected {selection}, which is not a valid option. \nPlease enter a number between 1 - 5.");
                    Console.WriteLine();
                }
                else if (validChoice == true && selection >= 1 && selection <= 5)
                {
                    //selection = selected;
                    Console.Clear();

                }
            }
            
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Add a new employee");
                    break;
                case 2:
                    Console.WriteLine("Update an employee");
                    break;
                case 3:
                    Console.WriteLine("Delete an employee");
                    break;
                case 4:
                    Console.WriteLine("View all employees");
                    break;
                case 5:
                    Console.WriteLine("You selected to Exit");
                    //Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You selected an invalid option");
                    break;
            }
            
        }
        while (runProgram == true);

    }
}
