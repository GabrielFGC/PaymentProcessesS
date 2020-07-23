using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessosDeContratos.Entities.Services
{
    class ContractSystem
    {
        private IPaymentService _paymentService;

        public ContractSystem(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessPayment(Contract contracts, int months)
        {
            double installmentPay = contracts.totalValue / months;

            for (int i = 1; i < months + 1; i++) 
            {
                DateTime paymentMonth = contracts.Date.AddMonths(i);

                double simplePayment = installmentPay + _paymentService.TaxPayment(installmentPay);
                double FinalPayment = simplePayment + _paymentService.PaymentMonths(simplePayment, i);

                contracts.InstallMents.Add(new InstallMent(paymentMonth, FinalPayment));
            }
        }
    }
}
