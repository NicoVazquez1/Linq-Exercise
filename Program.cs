// See https://aka.ms/new-console-template for more information

using LinqEmployees;

List<Employee> employees = new List<Employee>
{
    new Employee("John Doe", 30, "Manager", 120000, new DateTime(2015, 1, 1)),
    new Employee("Jane Smith", 25, "Developer", 98000, new DateTime(2016, 2, 1)),
    new Employee("Bob Johnson", 35, "Designer", 76000, new DateTime(2014, 3, 1)),
    new Employee("Alice Lee", 28, "Software Engineer", 110000, new DateTime(2017, 4, 1))
};

for (int i = 0; i < 50; i++)
{
    employees.Add(new Employee("Employee " + (i + 1), 20 + i % 10, "Position " + (i % 5 + 1), 50000 + i * 1000, new DateTime(2020 + i % 5, i % 12 + 1, i % 28 + 1)));
}

List<Department> departments = new List<Department>
{
    new Department("Sales"),
    new Department("Marketing"),
    new Department("Engineering")
};

int departmentIndex = 0;
foreach (Employee employee in employees)
{
    departments[departmentIndex].Employees.Add(employee);
    //Console.WriteLine($"Assigned {employee.Name} to {departments[departmentIndex].Name}");
    departmentIndex++;
    if (departmentIndex >= departments.Count) departmentIndex = 0;
}



List<double> salaries = EmployeeService.GetEmployeesSalary(employees);

foreach (var salary in salaries)
{
    Console.WriteLine(salary);
}

 /*
foreach (Employee employee in employees)
{
    Console.WriteLine("{0} ({1}) - {2} - ${3} - Hired on {4}", employee.Name, employee.Age, employee.Position, employee.Salary, employee.HireDate.ToShortDateString());
}
 */

