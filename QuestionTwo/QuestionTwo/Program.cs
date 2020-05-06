using System;
using System.Collections;
using System.Collections.Generic;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {

             DictionaryGeneric list = new DictionaryGeneric();

             list.Add("Tom Lee", "Training");
             list.Add("James Anderson", "HR");
             list.Add("Micheal Chan", "Content Development");
             list.Add("Jackie Jackson", "Training");
             list.Add("Bruce Douglas", "Graphics");
             list.Add("Kim Date", "HR");
             list.Add("Joseph Mathews", "Content Development");
             list.Add("Rose Dorson", "Marketing");
             list.Add("Andrews Stephan", "Graphics");

             Console.WriteLine("Original values stored in dictionary");
             list.GetDetails();
             Console.WriteLine("================================================================================");
            
            Console.WriteLine("=================Employee in alphabetical order using sortedlist==================");
            SortedList employee = new SortedList();
            employee.Add("Tom Lee", "Training");
            employee.Add("James Anderson", "HR");
            employee.Add("Micheal Chan", "Content Development");
            employee.Add("Jackie Jackson", "Training");
            employee.Add("Bruce Douglas", "Graphics");
            employee.Add("Kim Date", "HR");
            employee.Add("Joseph Mathews", "Content Development");
            employee.Add("Rose Dorson", "Marketing");
            employee.Add("Andrews Stephan", "Graphics");

            ICollection key = employee.Keys;
            
            foreach (string employees in key)
            {
                Console.WriteLine("Name:{0}\t  Department:{1}", employees, employee[employees]);
            }

            Console.WriteLine("============Using the ContainsValue() and Remove() method to remove a record =============");

            if (employee.ContainsValue("Andrews Stephan"))
            {
                Console.WriteLine("This name already exists");
            }
            else
            {
                employee.Remove("Andrews Stephan");
            }

            foreach (string employees in key)
            {
                Console.WriteLine("Name:{0}\t  Department:{1}", employees, employee[employees]);
            }
            Console.WriteLine("============================================");
            Console.ReadLine();
            

        }
    }
}
