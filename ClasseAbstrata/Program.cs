using System;
using System.Collections.Generic;
using System.Globalization;
using ClasseAbstrata.Entities;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPeople = new List<Person>(0);
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            //CREATE PERSONS
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company? (i/c): ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'I' || op == 'i')
                {
                    Console.Write("Health expenditure: ");
                    double healthEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listPeople.Add(new PhysicalPerson(name, anualIncome, healthEx));
                }
                else if (op == 'C' || op == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int nEmp = int.Parse(Console.ReadLine());

                    listPeople.Add(new JuridicalPerson(name, anualIncome, nEmp));
                }
            }

            //PRINT TAXES
            Console.WriteLine("TAXES PAID: ");

            foreach (Person p in listPeople)
            {
                Console.WriteLine(p.Name+": $"+p.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
