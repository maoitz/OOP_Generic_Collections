using System.Collections;

namespace OOP___Generic_Collections;
// Mowitz Almstedt .NET24 //

public class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee(1, "John", "Doe", "Male", 42000);
        Employee employee2 = new Employee(2, "Ida", "Brandt", "Female", 36000);
        Employee employee3 = new Employee(3, "Reidar", "Nilsen", "Male", 56000);
        Employee employee4 = new Employee(4, "Lisa", "Silver", "Female", 23000);
        Employee employee5 = new Employee(5, "Erik", "Berg", "Male", 27000);
        
        //LIFO - Last In First Out
        Stack employeeStack = new Stack();
        employeeStack.Push(employee1);
        employeeStack.Push(employee2);
        employeeStack.Push(employee3);
        employeeStack.Push(employee4);
        employeeStack.Push(employee5);

        //Print details of each employee
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nItems left in the Stack: {employeeStack.Count}"); Console.ResetColor();
        foreach (Employee emp in employeeStack)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(emp.ToString());
            Console.WriteLine($"Items left in the Stack: {employeeStack.Count}"); Console.ResetColor();
        }

        Console.WriteLine("--------------------------------------");
        
        //Print details of each employee using pop-method
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Retrieve Using Pop Method"); Console.ResetColor();
        int count = employeeStack.Count;
        Stack tempStack = new Stack(); //Temp stack to store popped items
        while (count > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Employee emp = (Employee)employeeStack.Pop();
            Console.WriteLine(emp.ToString());
            count--;
            Console.WriteLine($"Items left in the Stack: {count}"); Console.ResetColor();
            tempStack.Push(emp); //Push each popped item into temp stack
        }

        while (tempStack.Count > 0)
        {
            employeeStack.Push(tempStack.Pop()); //Push items in temp stack back to original stack
        }
        
        Console.WriteLine("--------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Stack restored: {employeeStack.Count}"); Console.ResetColor();
        Console.WriteLine("--------------------------------------");

        //Peek on the top object
        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Peek One:"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Employee firstPeek = (Employee)employeeStack.Peek();
        Console.WriteLine(firstPeek.ToString());
        Console.WriteLine($"Objects in stack: {employeeStack.Count}"); //Check count after each peek
        
        //Pop top object to peek on next in list
        Employee topEmp = (Employee)employeeStack.Pop();
        
        //Peek on the next object on the list (new top object after pop)
        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Peek Two:"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Employee secondPeek = (Employee)employeeStack.Peek();
        Console.WriteLine(secondPeek.ToString());
        Console.WriteLine($"Objects in stack: {employeeStack.Count}"); //Check count after each peek
        Console.ResetColor();
        
        //Push popped item back into stack
        employeeStack.Push(topEmp);
        
        Console.WriteLine("--------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Stack restored: {employeeStack.Count}"); Console.ResetColor();
        Console.WriteLine("--------------------------------------");

        //Check if object is in the Stack
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        if (employeeStack.Contains(employee3))
        {
            Console.WriteLine("Employee 3 is in the stack");
        }
        else
        {
            Console.WriteLine("Employee 3 is not in the stack");
        }
        Console.ResetColor();
        
        Console.WriteLine("--------------------------------------\n");
        
        //Cast stack objects to a List
        List<Employee> employeeList = employeeStack.Cast<Employee>().ToList();

        //Check if object is in the List
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        if (employeeList.Contains(employee2))
        {
            Console.WriteLine($"Employee id {employee2.Id} exists in the list\n");
        }
        else
        {
            Console.WriteLine($"Employee id {employee2.Id} doest not exist in the list\n");
        }
        Console.ResetColor();
        
        //Find() to get first object in the List with the value "Male" assigned to variable Gender
        Employee firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");

        if (firstMaleEmployee != null) //Check if the object exists AND has the same value
        {
            Console.WriteLine($"First employee found that is a male: \n{firstMaleEmployee.ToString()}\n");
        }
        else
        {
            Console.WriteLine("No male employee found");
        }

        //New list to use FindAll()
        Console.WriteLine("All male employees:");
        List<Employee> maleEmployee = new List<Employee>(employeeList.FindAll(emp => emp.Gender == "Male"));
        foreach (Employee male in maleEmployee)
        {
            Console.WriteLine(male.ToString());
        }
    }
}