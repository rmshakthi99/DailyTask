using System;
using System.Collections.Generic;
using System.Text;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    class EmployeeLogin
    {
        ILogin<Employee> repo;
        public EmployeeLogin()
        {
            repo = new EmployeeRepo();
        }
        public EmployeeLogin(ILogin<Employee> employeeRepo)
        {
            repo = employeeRepo;
        }
        public void Register()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDetails();
            repo.Add(employee);
        }
        public void Login()
        {
            Employee employee = new Employee();
            Console.WriteLine("please enter the username");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter password");
            employee.Password = Console.ReadLine();
            if (repo.Login(employee))
                Console.WriteLine("welcome");
            else
                Console.WriteLine("invalid username or password");
        }

    }
}
    

