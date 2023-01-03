using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimicJourney.HashBasedStructures
{
    public class HashBasedMethods
    {
        public void DictionaryOperations()
        {
            var employee = new Employee("Lucas", 1, "ti");
            var employee2 = new Employee("Valdirene", 2, "enfermagem");
            var employee3 = new Employee("Marcelo", 3, "construção civil");

            var employeesById = new Dictionary<int, Employee>();

            Employee person;

            employeesById.Add(employee.id, employee);
            employeesById.Add(employee2.id, employee2);
            employeesById.Add(employee3.id, employee3);


            if (employeesById.TryGetValue(2, out person))
            {
                Console.WriteLine(person.name + " : " + person.department);
            }
        }

        public void HashSetOperations()
        {
            var productCodes = new HashSet<string>();
            productCodes.Add("#1234");
            productCodes.Add("#5342");
            productCodes.Add("#6543");

            Console.WriteLine(productCodes.Contains("fd"));
            Console.WriteLine(productCodes.Contains("#1234"));




        }

        public void DisplayContent()
        {
            
        }
    }

    public class Employee
    {
        public string name;
        public int id;
        public string department;
        public Employee(string name, int id, string department) {
        this.name = name;
        this.id = id;
        this.department = department;
        }
       
    }
}
