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
        string[] menu = File.ReadAllLines("MenuFeature.txt");
        foreach (string line in menu)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("Please enter your choice: ");
        string choice = Console.ReadLine();

        //TODO: Fix this section of code it causes and error in the build
        //Maybe change to a do while loop

        /*
		bool runProgram = true;
		while (runProgram == true)
		{
            int featureChoice = 0;
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

                validChoice = int.TryParse(choice, out int featureChoice);

                if (validChoice == false)
                {
                    Console.WriteLine("Please enter a valid choice.");
                }
                else if (featureChoice < 1 || featureChoice > 5)
                {
                    Console.WriteLine("Please enter a valid choice.");
                }
                else
                {
                    validChoice = true;
                }
            }

            switch (featureChoice)
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
                    Console.WrtieLine("View all employees");
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    Console.ReadKey();
                    runProgram = false;
                    break;
            }
           
        }
        */
    }
}
