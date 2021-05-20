using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculation.Entities.Abstract
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public decimal AnnualIncome { get; set; }

        public abstract decimal TaxCalculation();
    }
}
