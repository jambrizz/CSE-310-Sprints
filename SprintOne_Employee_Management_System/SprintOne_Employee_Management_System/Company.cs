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
                    //Case 1 is to add an employee to the list of employees
                    Console.Clear();
                    Employee e = new Employee();
                    e.addEmployee();
                    string employeeToAdd = e.getEmployeeInfo();
                    employees.Add(employeeToAdd);
                    break;
                case 2:
                    Employee e2 = new Employee();
                    Console.Clear();
                    DisplayListOfEmployees();
                    Console.WriteLine("Enter the corresponding number of the employee you wish to update.");
                    int employeeNumberToUpdate = Convert.ToInt32(Console.ReadLine());
                    int employeeIndexToUpdate = employeeNumberToUpdate - 1;
                    string employeeToUpdate = employees[employeeIndexToUpdate];                    
                    e2.splitEmployeeInfo(employeeToUpdate);
                    e2.updateEmployee();
                    string updatedEmployee = e2.getEmployeeInfo();
                    employees[employeeIndexToUpdate] = updatedEmployee;

                    //Console.WriteLine("Update an employee");
                    break;
                case 3:
                    //Case 3 is to delete an employee from the list of employees
                    Console.Clear();
                    DisplayListOfEmployees();
                    Console.WriteLine("Enter the corresponding number of the employee you wish to delete from the company record.");
                    int employeeNumberToDelete = Convert.ToInt32(Console.ReadLine());
                    int employeeIndexToDelete = employeeNumberToDelete - 1;
                    employees.RemoveAt(employeeIndexToDelete);
                    Console.Clear();
                    Console.WriteLine("Employee deleted successfully!");
                    break;
                case 4:
                    //Case 4 is to view a selected employee from the company
                    Employee e4 = new Employee();
                    Console.Clear();
                    DisplayListOfEmployees();
                    Console.WriteLine("Enter the corresponding number of the employee you wish to see.");
                    int employeeNumber = Convert.ToInt32(Console.ReadLine());
                    int employeeIndex = employeeNumber - 1;
                    string employee = employees[employeeIndex];
                    e4.splitEmployeeInfo(employee);
                    e4.EmployeeInfo();
                    break;
                case 5:
                    Console.WriteLine("You selected to Exit");
                    Console.WriteLine("Thank you for using the Employee Management System!");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey();
                    runProgram = false;
                    //Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You selected an invalid option");
                    break;
            }
            
        }
        while (runProgram == true);        
    }

    private void DisplayListOfEmployees()
    {
        Console.WriteLine("*********** Employees List  ****************");
        Console.WriteLine("********************************************");
        int lenght = employees.Count;
        for (int i = 0; i < lenght; i++)
        {
            int number = i + 1;
            string firstNameRaw = employees[i].Split("FirstName:")[1];
            string firstName = firstNameRaw.Split('|')[0];
            string lastNameRaw = employees[i].Split("LastName:")[1];
            string lastName = lastNameRaw.Split('|')[0];
            Console.WriteLine($"{number}. {firstName} {lastName}");
        }
        Console.WriteLine("********************************************\n\n");
    }
}
