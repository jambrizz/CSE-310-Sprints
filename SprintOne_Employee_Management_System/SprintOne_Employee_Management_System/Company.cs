using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

public class Company
{
	//private string _menu = "MenuFeature.txt";
	private List<string> employees = new List<string>();
	public void runCompanyApp()
	{
        bool runProgram = true;
        do
        {
            int selected = 0;
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

                bool isNumber = int.TryParse(choice, out selected);
                Console.WriteLine(isNumber);
                if (isNumber == false)
                { 
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number");
                    Console.WriteLine();
                }
                else if (isNumber == true && selected <1 || selected > 5)
                {
                    Console.Clear();
                    Console.WriteLine($"You selected {selected}, which is not a valid option. \nPlease enter a number between 1 - 5.");
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    validChoice = true;
                }
            }
            
            switch (selected)
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
