using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Lab8OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "Charlotte", "Female", 35000); //Creating new objects to Employee class
            Employee employee2 = new Employee(102, "Vera", "Female", 50000);
            Employee employee3 = new Employee(103, "Jan", "Male", 29000);
            Employee employee4 = new Employee(104, "Anton", "Male", 45000);
            Employee employee5 = new Employee(105, "Maja", "Female", 60000);

            //Part 1 Stack
            Console.WriteLine("Part 1:");

            Stack<Employee> employeeStack = new Stack<Employee>(); //Creating new stack

            employeeStack.Push(employee1); //Adding objects to stack
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("Retrieve using foreach loop");
            foreach (Employee employee in employeeStack) //Loop for writnig out all objects in stack
            {
                PrintEmployeeInfo(employee); //Method to print employee info
                PrintObjectsInStack(employeeStack.Count); //Method to print info on number of objects left in stack
            }

            Console.WriteLine("------------------------------"); //Separator

            Console.WriteLine("Retrieve using Pop method");
            while (employeeStack.Count > 0) //Loop for writing out object which also is removed
            {
                PrintEmployeeInfo(employeeStack.Pop()); //Empties the stack one by one and prints info
                PrintObjectsInStack(employeeStack.Count); //Prints info on objects left in stack
            }
            
            employeeStack.Push(employee1); //Adding objects to stack again after Pop method removed them
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("------------------------------");

            Console.WriteLine("Retrieve using Peek method");
            for (int i = 0; i < 2; i++) //Loop for looking at latest added object to stack for 2 iterations
            {
                PrintEmployeeInfo(employeeStack.Peek()); //Looks (peeks) at the latest object in stack and prints info
                PrintObjectsInStack(employeeStack.Count); //Prints info on objects left in stack
            }

            Console.WriteLine("------------------------------");

            if (employeeStack.Contains(employee3)) //If loop to check if e3 is in stack and print depending on true/false
            {
                Console.WriteLine("Employee3 exists in the Stack.");
            }
            else
            {
                Console.WriteLine("Employee3 does not exist in the Stack.");
            }

            //Part 2 List
            Console.WriteLine("\nPart 2:");

            List<Employee> employeeList = new List<Employee>(); //Creating new list

            employeeList.Add(employee1); //Adding objects to list
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            if (employeeList.Contains(employee2)) //If loop to check if e2 is in list and print depending on true/false
            {
                Console.WriteLine("Employee2 object exists in the List.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the List");
            }

            Console.WriteLine();

            Employee firstMaleEmployee = employeeList.Find((employee) => employee.Gender == "Male"); //Create list with first employee object that have male gender
            PrintEmployeeInfo(firstMaleEmployee); //Print object in new list with employee information
            
            Console.WriteLine();

            List<Employee> maleEmployeeList = employeeList.FindAll((employee) => employee.Gender == "Male"); //Create list with all employee objects that have male gender

            foreach (Employee maleEmployee in maleEmployeeList) //Prints out all objects in list
            {
                PrintEmployeeInfo(maleEmployee);
            }
        }

        //Methods

        static void PrintEmployeeInfo(Employee e) //Method to write out all information in object
        {
            Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Gender: {e.Gender}, Salary: {e.Salary}"); 
        }

        static void PrintObjectsInStack(int stackSize) //Method to print number of objects left in stack
        {
            Console.WriteLine($"Objects left in the Stack: {stackSize}");
        }

    }


}