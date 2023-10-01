using System;

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
    }

    //This method will be used to display a single employee's information
	public void EmployeeInfo()
    {
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
    }

    //TODO: Continue working on this method
    public void addEmployee()
    {
        var random = new Random();
        var employeeID = random.Next(1000, 9999);
        _employeeID = employeeID;
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
        //Console.WriteLine(getEmployeeInfo());
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
            $"|Employed:{_employed}";
    }

}
