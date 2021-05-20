using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TaxCalculation.Entities.Abstract
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public decimal AnnualIncome { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, decimal annualIncome)
        {
            this.Name = name;
            this.AnnualIncome = annualIncome;
        }

        public abstract decimal TaxCalculation();

        public override string ToString()
        {
            return $"{this.Name}: $ {this.TaxCalculation().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
