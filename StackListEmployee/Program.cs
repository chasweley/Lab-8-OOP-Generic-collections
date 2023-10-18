using System.Collections.Immutable;

namespace StackListEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Charlotte", "Female", 35000); //Creating new objects to Employee class
            Employee e2 = new Employee(102, "Vera", "Female", 50000);
            Employee e3 = new Employee(103, "Jan", "Male", 29000);
            Employee e4 = new Employee(104, "Anton", "Male", 45000);
            Employee e5 = new Employee(105, "Maja", "Female", 60000);

            Stack<Employee> employees = new Stack<Employee>(); //Creating new stack

            employees.Push(e1); //Adding above created objects to stack
            employees.Push(e2);
            employees.Push(e3);
            employees.Push(e4);
            employees.Push(e5);

            Console.WriteLine($"Objects in stack: {employees.Count}"); //Writes out amount of objects in stack
            foreach (Employee e in employees) //Loop for writng out all objects in stack
            {
                Console.WriteLine($"{e.ID} - {e.Name} - {e.Gender} - {e.Salary}");
                Console.WriteLine($"Objects left in stack: {employees.Count}");
            }

            Console.WriteLine("------------------------------"); //Separator

            Console.WriteLine("Retrieve using Pop method");
            while (employees.Count > 0) //Loop for writing out object which also is removed
            {
                Employee ePop = employees.Pop(); //Empties the stack one by one
                Console.WriteLine($"{ePop.ID} - {ePop.Name} - {ePop.Gender} - {ePop.Salary}"); //Writes out everything in last object that is removed
                Console.WriteLine($"Objects left in stack: {employees.Count}"); //Checks objects left in stack
            }

            employees.Push(e1); //Adding objects to stack again after Pop method removed them
            employees.Push(e2);
            employees.Push(e3);
            employees.Push(e4);
            employees.Push(e5);

            Console.WriteLine("------------------------------"); //Separator

            Console.WriteLine("Retrieve using Peek method");
            for (int i = 0;  i < 2; i++) //Loop for looking at latest added object to stack for 2 iterations
            {
                Employee ePeek = employees.Peek(); //Looks (peeks) at the latest object in stack
                Console.WriteLine($"{ePeek.ID} - {ePeek.Name} - {ePeek.Gender} - {ePeek.Salary}"); //Writes out everything in latest object
                Console.WriteLine($"Objects left in stack: {employees.Count}"); //Checks objects left in stack
            }

            Console.WriteLine("------------------------------"); //Separator

            if (employees.Contains(e3))
            {
                Console.WriteLine("Found employee, e3 is in stack.");
            }
            else
            {
                Console.WriteLine("Not found.");
            }

            //static void PrintEmployees(IEnumerable<Employee> ids)
            //{
            //    foreach (Employee i in ids)
            //    {
            //        Console.WriteLine($"{i.ID} - {i.Name} - {i.Gender} - {i.Salary}");
            //    }
            //}


        }
    }
}