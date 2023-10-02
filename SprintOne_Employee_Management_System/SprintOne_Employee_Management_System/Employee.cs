using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

public class Employee
{
    private string _firstName;
    private string _lastName;
    private string _addressStreet;
    private string _addressCity;
    private string _addressState;
    private int _addressZip;
    private long _phoneNumber;
    private string _email;
    private int _employeeID;
    private int _socialSecurityNumber;
    private string _dateOfBirth;
    private string _jobTitle;
    private double _hourlyRate;
    private string _typeOfEmployment;
    private bool _employed;

    //This method is to generate a random employee ID
    private int employeeID()
    {
        Random random = new Random();
        int employeeID = random.Next(1000, 9999);
        return employeeID;
    }

    //This method is to split the employee's information into strings to be added to the fields in the class
    public void splitEmployeeInfo(string employeeInfo)
    {
        string rawLine = employeeInfo;
        string firstNameRaw = rawLine.Split("FirstName:")[1];
        string firstName = firstNameRaw.Split("|")[0];
        _firstName = firstName;
        string lastNameRaw = rawLine.Split("LastName:")[1];
        string lastName = lastNameRaw.Split("|")[0];
        _lastName = lastName;
        string addressStreetRaw = rawLine.Split("AddressStreet:")[1];
        string addressStreet = addressStreetRaw.Split("|")[0];
        _addressStreet = addressStreet;
        string addressCityRaw = rawLine.Split("AddressCity:")[1];
        string addressCity = addressCityRaw.Split("|")[0];
        _addressCity = addressCity;
        string addressStateRaw = rawLine.Split("AddressState:")[1];
        string addressState = addressStateRaw.Split("|")[0];
        _addressState = addressState;
        string addressZipRaw = rawLine.Split("AddressZipcode:")[1];
        int addressZip = Convert.ToInt32(addressZipRaw.Split("|")[0]);
        _addressZip = addressZip;
        string phoneNumberRaw = rawLine.Split("Telephone:")[1];
        long phoneNumber = Convert.ToInt64(phoneNumberRaw.Split("|")[0]);
        _phoneNumber = phoneNumber;
        string emailRaw = rawLine.Split("Email:")[1];
        string email = emailRaw.Split("|")[0];
        _email = email;
        string socialSecurityNumberRaw = rawLine.Split("SSN:")[1];
        int socialSecurityNumber = Convert.ToInt32(socialSecurityNumberRaw.Split("|")[0]);
        _socialSecurityNumber = socialSecurityNumber;
        string dateOfBirthRaw = rawLine.Split("DateOfBirth:")[1];
        string dateOfBirth = dateOfBirthRaw.Split("|")[0];
        _dateOfBirth = dateOfBirth;
        string jobTitleRaw = rawLine.Split("JobTitle:")[1];
        string jobTitle = jobTitleRaw.Split("|")[0];
        _jobTitle = jobTitle;
        string hourlyRateRaw = rawLine.Split("HourlyRate:")[1];
        double hourlyRate = Convert.ToDouble(hourlyRateRaw.Split("|")[0]);
        _hourlyRate = hourlyRate;
        string typeOfEmploymentRaw = rawLine.Split("TypeOfEmployment:")[1];
        string typeOfEmployment = typeOfEmploymentRaw.Split("|")[0];
        _typeOfEmployment = typeOfEmployment;
        string employedRaw = rawLine.Split("Employed:")[1];
        bool employed = Convert.ToBoolean(employedRaw.Split("|")[0]);
        _employed = employed;
        string employeeIDRaw = rawLine.Split("EmployeeID:")[1];
        int employeeID = Convert.ToInt32(employeeIDRaw.Split("|")[0]);
        _employeeID = employeeID;
    }

    //This method will be used to display a single employee's information
	public void EmployeeInfo()
    {
        Console.Clear();
        Console.WriteLine($"Employee Info \n\n" +
            $"Employee ID: {_employeeID}\n" +
            $"First Name: {_firstName}\n" +
            $"Last Name: {_lastName}\n" +
            $"Street Address: {_addressStreet}\n" +
            $"City: {_addressCity}\n" +
            $"State: {_addressState}\n" +
            $"Telephone No.: {_phoneNumber}\n" +
            $"Email: {_email}\n" +
            $"Social Security No.: {_socialSecurityNumber}\n" +
            $"Date of Birth: {_dateOfBirth}\n\n" +
            $"Employment Details\n\n" +
            $"Company Position: {_jobTitle}\n" +
            $"Hourly Rate: {_hourlyRate}\n" +
            $"Type of Employment: {_typeOfEmployment}\n" +
            $"Currently Employed: {_employed}\n\n" +
            $"End of employee details...\n\n" +
            $"Press any key to return to the main menu.");
        Console.ReadKey();
        Console.Clear();
    }

    //This method will be used to update an employee's information
    public void updateEmployee()
    {
        Console.Clear();
        bool runUpdate = true;
        do
        {
            int selection = 0;
            bool validSelection = false;
            while (validSelection == false)
            {
                Console.WriteLine("**************    Employee info    *******************");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine($"1. Employee ID: {_employeeID}");
                Console.WriteLine($"2. First Name: {_firstName}");
                Console.WriteLine($"3. Last Name: {_lastName}");
                Console.WriteLine($"4. Street Address: {_addressStreet}");
                Console.WriteLine($"5. City: {_addressCity}");
                Console.WriteLine($"6. State: {_addressState}");
                Console.WriteLine($"7. Telephone No.: {_phoneNumber}");
                Console.WriteLine($"8. Email: {_email}");
                Console.WriteLine($"9. Social Security No.: {_socialSecurityNumber}");
                Console.WriteLine($"10. Date of Birth: {_dateOfBirth}\n");
                Console.WriteLine("**************    Employment Details    ***************");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine($"11. Company Position: {_jobTitle}");
                Console.WriteLine($"12. Hourly Rate: {_hourlyRate}");
                Console.WriteLine($"13. Type of Employment: {_typeOfEmployment}");
                Console.WriteLine($"14. Currently Employed: {_employed}\n");
                Console.WriteLine("15. To exit update page.");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine("Enter the corresponding number of the field you wish to update.");
                string selected = Console.ReadLine();
                
                validSelection = int.TryParse(selected, out selection);
                if (validSelection == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number");
                    Console.WriteLine();
                }
                else if (validSelection == true && selection < 1 || selection > 15)
                {
                    Console.Clear();
                    Console.WriteLine($"You selected {selection}, which is not a valid option. \nPlease enter a number between 1 - 15.");
                    Console.WriteLine();
                }
                else if (validSelection == true && selection >= 1 && selection <= 15)
                {
                    Console.Clear();
                }
            }
            switch (selection)
            {
                case 1:
                    Console.WriteLine($"Current Employee ID: {_employeeID}");
                    Console.WriteLine("Please enter the new Employee ID: ");
                    _employeeID = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine($"Current First Name: {_firstName}");
                    Console.WriteLine("Please enter the new First Name: ");
                    _firstName = Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine($"Current Last Name: {_lastName}");
                    Console.WriteLine("Please enter the new Last Name: ");
                    _lastName = Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine($"Current Street Address: {_addressStreet}");
                    Console.WriteLine("Please enter the new Street Address: ");
                    _addressStreet = Console.ReadLine();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine($"Current City: {_addressCity}");
                    Console.WriteLine("Please enter the new City: ");
                    _addressCity = Console.ReadLine();
                    Console.Clear();
                    break;
                case 6:
                    Console.WriteLine($"Current State: {_addressState}");
                    Console.WriteLine("Please enter the new State: ");
                    _addressState = Console.ReadLine();
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine($"Current Telephone No.: {_phoneNumber}");
                    Console.WriteLine("Please enter the new Telephone No.: ");
                    _phoneNumber = Convert.ToInt64(Console.ReadLine());
                    Console.Clear();
                    break;
                case 8:
                    Console.WriteLine($"Current Email: {_email}");
                    Console.WriteLine("Please enter the new Email: ");
                    _email = Console.ReadLine();
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine($"Current Social Security No.: {_socialSecurityNumber}");
                    Console.WriteLine("Please enter the new Social Security No.: ");
                    _socialSecurityNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    break;
                case 10:
                    Console.WriteLine($"Current Date of Birth: {_dateOfBirth}");
                    Console.WriteLine("Please enter the new Date of Birth: ");
                    _dateOfBirth = Console.ReadLine();
                    Console.Clear();
                    break;
                case 11:
                    Console.WriteLine($"Current Company Position: {_jobTitle}");
                    Console.WriteLine("Please enter the new Company Position: ");
                    _jobTitle = Console.ReadLine();
                    Console.Clear();
                    break;
                case 12:
                    Console.WriteLine($"Current Hourly Rate: {_hourlyRate}");
                    Console.WriteLine("Please enter the new Hourly Rate: ");
                    _hourlyRate = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    break;
                case 13:
                    Console.WriteLine($"Current Type of Employment: {_typeOfEmployment}");
                    Console.WriteLine("Please enter the new Type of Employment: ");
                    _typeOfEmployment = Console.ReadLine();
                    Console.Clear();
                    break;
                case 14:
                    Console.WriteLine($"Current Employment Status: {_employed}");
                    Console.WriteLine("Please enter the new Employment Status: ");
                    _employed = Convert.ToBoolean(Console.ReadLine());
                    Console.Clear();
                    break;
                case 15:
                    Console.Clear();
                    runUpdate = false;
                    break;
            }
        }
        while (runUpdate == true);
    }

    //This method is to add a new employee to the list of employees
    public void addEmployee()
    {
        int newID = employeeID();
        _employeeID = newID;
        Console.WriteLine("Please enter the employee's first name: ");
        _firstName = Console.ReadLine();
        Console.WriteLine("Please enter the employee's last name: ");
        _lastName = Console.ReadLine();
        Console.WriteLine("Please enter the employee's street address ex(123 Main Street): ");
        _addressStreet = Console.ReadLine();
        Console.WriteLine("Please enter the employee's city: ");
        _addressCity = Console.ReadLine();
        Console.WriteLine("Please enter the employee's state: ");
        _addressState = Console.ReadLine();
        Console.WriteLine("Please enter the employee's zip code: ");
        _addressZip = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the employee's phone number (no dashes or paranthesis): ");
        _phoneNumber = Convert.ToInt64(Console.ReadLine()) ;
        Console.WriteLine("Please enter the employee's email address: ");
        _email = Console.ReadLine();
        Console.WriteLine("Please enter the employee's social security number (no dashes): ");
        _socialSecurityNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the employee's date of birth (MM/DD/YYYY): ");
        _dateOfBirth = Console.ReadLine();
        Console.WriteLine("Please enter the employee's job title: ");
        _jobTitle = Console.ReadLine();
        Console.WriteLine("Please enter the employee's hourly rate: ");
        _hourlyRate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the employee's type of employment (full-time, part-time, or contractor): ");
        _typeOfEmployment = Console.ReadLine();
        Console.WriteLine("Is the employee currently employed? (true or false): ");
        _employed = Convert.ToBoolean(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Employee added successfully!");
        Console.WriteLine();
    }

    public string getEmployeeInfo()
    {
        //This method will return the employee's information to be added to the list of employees in the Company class
        return $"FirstName:{_firstName}" +
            $"|LastName:{_lastName}" +
            $"|AddressStreet:{_addressStreet}" +
            $"|AddressCity:{_addressCity}" +
            $"|AddressState:{_addressState}" +
            $"|AddressZipcode:{_addressZip}" +
            $"|Telephone:{_phoneNumber}" +
            $"|Email:{_email}" +
            $"|SSN:{_socialSecurityNumber}" +
            $"|DateOfBirth:{_dateOfBirth}" +
            $"|JobTitle:{_jobTitle}" +
            $"|HourlyRate:{_hourlyRate}" +
            $"|TypeOfEmployment:{_typeOfEmployment}" +
            $"|Employed:{_employed}" +
            $"|EmployeeID:{_employeeID}";
    }

}
