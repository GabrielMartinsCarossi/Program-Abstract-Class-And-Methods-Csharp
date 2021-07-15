using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrata.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenditure { get; set; }

        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double anualIncome, double healthExpenditure)
            : base(name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax()
        {
            double tax = 0;

            if (AnualIncome < 20000)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditure > 0)
            {
                tax -= HealthExpenditure / 2;
            }

            return tax;
        }
        
    }
}
