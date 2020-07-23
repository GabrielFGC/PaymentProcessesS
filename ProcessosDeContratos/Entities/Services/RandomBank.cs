using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessosDeContratos.Entities.Services
{
    class RandomBank : IPaymentService
    {
        private double _interestRates = 0.01;
        private double _taxPayment = 0.02;

        public double TaxPayment(double amount)
        {
            return (amount * _taxPayment);
        }
        public double PaymentMonths(double amount, int moths)
        {
            return (amount * _interestRates) * moths;
        }
    }
}
