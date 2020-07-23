using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessosDeContratos.Entities.Services
{
    interface IPaymentService
    {
        double TaxPayment(double amount);
        double PaymentMonths(double amount, int moths);
    }
}
