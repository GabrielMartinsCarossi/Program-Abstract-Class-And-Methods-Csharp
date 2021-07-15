using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrata.Entities
{
    class JuridicalPerson : Person
    {
        public int NumberEmployees { get; set; }

        public JuridicalPerson()
        {
        }

        public JuridicalPerson(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            double tax = 0;

            if (NumberEmployees > 10)
            {
                tax = AnualIncome * 0.14;
            }
            else
            {
                tax = AnualIncome * 0.16;
            }

            return tax;
        }
    }
}
