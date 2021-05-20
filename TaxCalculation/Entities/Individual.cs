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
            var baseTax = (this.AnnualIncome < 20000M) ? 0.15M : 0.25M;
            var healthExpenditures = (this.HealthCareSpending > 0.00M) ? 0.50M : 0.00M;

            return (this.AnnualIncome * baseTax) - (this.HealthCareSpending * healthExpenditures);
        }
    }
}
