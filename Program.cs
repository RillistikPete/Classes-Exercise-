using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Company Hydra = new Company("Hydra Beats", DateTime.Now);

            Employee Pete = new Employee("Pete", "Producer", DateTime.Now);
            Hydra.addEmployee(Pete);
            Employee Garren = new Employee("Garren", "Physician", DateTime.Now);
            Hydra.addEmployee(Garren);
            Employee Squeaky = new Employee("Squeaky", "Shaman", DateTime.Now);
            Hydra.addEmployee(Squeaky);

            Hydra.ListEmployees();

        }
    }

                       

            
            public class Company
                {
                    /*
                        Some readonly properties
                    */
                    public string Name { get; }
                    public DateTime CreatedOn { get; }

                    // Create a property for holding a list of current employees

                    public List<Employee> EmployeeList = new List<Employee>();

                    // Create a method that allows external code to add an employee
                    public void addEmployee(Employee employee) {
                        EmployeeList.Add(employee);
                    }

                    // Create a method that allows external code to remove an employee
                    public void removeEmployee(Employee employee) {
                        EmployeeList.Remove(employee);
                    }
                    /*
                        Create a constructor method that accepts two arguments:
                            1. The name of the company
                            2. The date it was created

                        The constructor will set the value of the public properties
                    */
                    public Company (string name, DateTime dateCreated){
                        Name = name;
                        CreatedOn = dateCreated;
                    }
                
                    public void ListEmployees() {
                        foreach (Employee E in EmployeeList){
                            Console.WriteLine($"{E.EmployeeName}");
                        }
                    }
                }

            public class Employee
                {
                    public string EmployeeName { get; set; }
                    public string EmployeeJob { get; set; }
                    public DateTime StartDate { get; set; }

                    public Employee (string name, string job, DateTime date)
                    {
                        EmployeeName = name;
                        EmployeeJob = job;
                        StartDate = date;
                    }

                }
                
}

