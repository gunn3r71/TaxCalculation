using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculation.Entities.Abstract;

namespace TaxCalculation.Entities
{
    class Corporation : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Corporation()
        {
        }

        public Corporation(string name, decimal annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            this.NumberOfEmployees = numberOfEmployees;
        }

        public override decimal TaxCalculation()
        {
            throw new NotImplementedException();
        }
    }
}
