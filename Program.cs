// Make a list of employees and sort them 

var employeesOverview = new Employees();

var Inger = new Employee("Inger", 5000);
var ArneMarius = new Employee("Arne Marius", 6000);
var Irgen = new Employee("Irgen?", 4000);

employeesOverview.addEmployees(Inger);
employeesOverview.addEmployees(ArneMarius);
employeesOverview.addEmployees(Irgen);

employeesOverview.getEmployees();

employeesOverview.sortByName();
employeesOverview.sortBySalary();


public class Employees
{
  public List<Employee> DetailedListofEmployees = new List<Employee>();

  public void getEmployees()
  {
    foreach (var employee in DetailedListofEmployees)
    {
        Console.WriteLine(employee.Name + " earns " + employee.Salary);
    }
    Console.WriteLine(" ");
  }

  public void addEmployees(Employee employee)
  {
    DetailedListofEmployees.Add(employee);
  }

  public void sortByName()
  {
        List<Employee> sortedByName = DetailedListofEmployees.OrderBy(employee => employee.Name).ToList();

        foreach (var employee in sortedByName)
        {
            Console.WriteLine($"Name: {employee.Name}");
        }
        
        Console.WriteLine(" ");
  }
  public void sortBySalary()
  {
        List<Employee> sortedBySalary = DetailedListofEmployees.OrderBy(employee => employee.Salary).ToList();

        foreach (var employee in sortedBySalary)
        {
            Console.WriteLine($"{employee.Name}'s salary is: {employee.Salary}");
        }
        Console.WriteLine(" ");
  }
}

public class Employee
{
  public string Name { get; }
  public int Salary { get; private set; }
  public Employee(string name, int salary)
  {
    Name = name; 
    Salary = salary;
  }
}