using System;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    class Program
    {
        EmployeeLogin login;
        EmployeeCRUD employeeCRUD;
        EmployeeRepo employeeRepo;
        public Program()
        {
            login = new EmployeeLogin();
            employeeRepo = new EmployeeRepo();
            employeeCRUD = new EmployeeCRUD(employeeRepo);
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("3.Print Employees");
                Console.WriteLine("4.exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login.Login();
                        break;
                    case 2:
                        login.Register();
                        break;
                    case 3:
                        employeeCRUD.PrintAllEmployees();
                        break;
                    case 4:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            } while (choice != 4);
        }
        static void Main(string[] args)
        {
            new Program().PrintMenu();
            Console.ReadKey();

        }
    }
}








