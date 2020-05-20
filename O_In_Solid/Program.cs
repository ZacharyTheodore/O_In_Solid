using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPLibrary;

namespace O_In_Solid
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel {FirstName = "Zac", LastName = "Theodore"},
                new PersonModel {FirstName = "Michelle", LastName = "Thornhill"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person)); 
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} Is Manager: {emp.IsManager}");
            }

            Console.ReadLine();


        }
    }
}
