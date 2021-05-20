using System;
using TaxCalculation.Entities.Abstract;
using TaxCalculation.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var taxPayersList = new List<TaxPayer>();

                Console.Write("Enter the number of tax payers: ");
                var numberTaxpayers = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberTaxpayers; i++)
                {
                    Console.WriteLine($"Tax payer #{i} data:");
                    Console.Write("Individual or company (i/c)? ");
                    char payerType = char.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Annual income: ");
                    var annualIncome = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (payerType == 'i' || payerType == 'I')
                    {
                        Console.Write("Health expenditures: ");
                        var healthExpend = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        taxPayersList.Add(new Individual(name,annualIncome,healthExpend));
                    }
                    else
                    {
                        Console.Write("Number of employees: ");
                        var numberEmployees = int.Parse(Console.ReadLine());
                        taxPayersList.Add(new Corporation(name,annualIncome,numberEmployees));
                    }
                }

                var totalTaxes = 0.00M;

                Console.WriteLine("\nTAXES PAID:");
                foreach (var taxPayer in taxPayersList)
                {
                    Console.WriteLine(taxPayer);
                    totalTaxes += taxPayer.TaxCalculation();
                }

                Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
