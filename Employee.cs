namespace OOP___Generic_Collections;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public double Salary { get; set; } //Monthly salary in sek

    public Employee(int id, string firstName, string lastName, string gender, double salary)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Salary = salary;
    }

    //Override ToString for easy print of properties
    public override string ToString()
    {
        return $"{Id} - {FirstName} {LastName} - {Gender} - ${Salary}";
    }

    public void PrintObject()
    {
        
    }
}