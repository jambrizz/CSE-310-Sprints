using System;

public class Employee
{
    private string _firstName;
    private string _lastName;
    private string _addressStreet;
    private string _addressCity;
    private string _addressState;
    private int _addressZip;
    private int _phoneNumber;
    private string _email;
    private int _employeeID;
    private int _socialSecurityNumber;
    private string _jobTitle;
    private double _hourlyRate;
    private string _typeOfEmployment;
    private bool _employed;
	public void EmployeeInfo()
    {
        
    }

    //TODO: Continue working on this method
    public string addEmployee()
    {
        string line = "";
        var random = new Random();
        var employeeID = random.Next(1000, 9999);
        //TODO: test out the employeeID to see if it is unique & that it is added to the string line
        line += "Employee ID:" + employeeID + "|";
        Console.WriteLine("Please enter the employee's first name: ");
        _firstName = Console.ReadLine();
        //TODO: test out the _firstName to see if it is added to the string line
        return "";
    }
}
