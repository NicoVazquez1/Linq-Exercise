using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmployees
{
    public static class EmployeeService
    {
        public static List<double> GetEmployeesSalary(List<Employee> employees)
            => employees.Select(e => e.Salary).OrderBy(s => s).ToList();

        public static IEnumerable<Employee> GetEmployeesAboveSalary(List<Employee> employees, double salary)
            => employees.Where(e => e.Salary >= salary).OrderBy(e => e.Salary);

        public static IEnumerable<Employee> GetEmployeesBeforeHireDate(List<Employee> employees, int year, int mounth, int day) 
            => employees.Where(e => e.HireDate <= new DateTime(year, mounth, day)).OrderByDescending(e => e.Salary);

        public static Dictionary<double, List<Employee>> GetEmployeesGroupBySalary(List<Employee> employees)
            => employees.GroupBy(e => e.Salary).ToDictionary(g => g.Key, g => g.ToList());


    }
}
