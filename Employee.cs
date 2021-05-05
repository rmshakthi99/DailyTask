using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportManagementBLLibrary
{
    public class Employee : IComparable<Employee>
    {
        const string DEFAULT_PASSWORD = "1234";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public Employee()
        {
            Password = DEFAULT_PASSWORD;
        }
        public Employee(int id, string name, string location, string phone)
        {
            Id = id;
            name = name;
            location = location;
            Password = DEFAULT_PASSWORD;
        }
        public void GetEmployeeDetails()
        {
            Console.WriteLine("please enter employee name");
            Name = Console.ReadLine();
            Console.WriteLine("please enter employee phone number");
            Phone = Console.ReadLine();
            Console.WriteLine("please enter employee location");
            Location = Console.ReadLine();
        }
        public override string ToString()
        {
            string maskedPassword = GetMaskedPassword(Password);
            return "Employee Id : " + Id + "Name:" + Name + "Phone:" + Phone + " Location:" + Location;
        }

        private string  GetMaskedPassword(string password)
        {
            string result = password.Substring(0, 2);
            for (int i = 2; i < password.Length; i++)
            {
                result = result + "*";

            }
            return result;
        }
        public int CompareTo(Employee other)
        {
            return this.Location.CompareTo(other.Location);
        }
    }



















    }
