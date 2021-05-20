using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculation.Entities.Abstract;

namespace TaxCalculation.Entities
{
    class Individual : TaxPayer
    {
        public decimal HealthCareSpending { get; set; }

        public Individual()
        {
        }

        public Individual(string name, decimal annualIncome, decimal healthCareSpending) : base(name, annualIncome)
        {
            this.HealthCareSpending = healthCareSpending;
        }

        public override decimal TaxCalculation()
        {
            throw new NotImplementedException();
        }
    }
}
