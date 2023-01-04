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

        public List<int> findMissingNumbers(int[] first, int[] second)
        {
            var missingNumbers = new List<int>();
            var secondArrayItems = new HashSet<int>();

            foreach(int item in second)
            {
                secondArrayItems.Add(item);
            }

            foreach(int item in first)
            {
                if(secondArrayItems.Contains(item)) 
                    missingNumbers.Add(item);
            }

            return missingNumbers;
        }

        public void DisplayFrequenceOfEachElement(int[] array)
        {
            var freqDictionary = new Dictionary<int, int>();

            for(int i = 0; i < array.Length; i++)
            {
                if (freqDictionary.ContainsKey(array[i]))
                {
                    freqDictionary[array[i]]++;
                } else {
                    freqDictionary[array[i]] = 1;
                }
            }

            foreach(KeyValuePair<int,int> x in freqDictionary)
            {
                Console.WriteLine(x.Key + " -> " + x.Value);
            }
        }

        public void DisplayContent()
        {
            int[] array1 = new int[] { 3, 2, 8, 4, 5 };
            int[] array2 = new int[] { 5, 3, 7, 0, 2, 2, 7 ,5, 5, 5 };
            var result = findMissingNumbers(array1, array2);
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            DisplayFrequenceOfEachElement(array2);

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
