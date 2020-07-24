using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProcessosDeContratos.Entities
{
    class InstallMent
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }
        public InstallMent(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date: {DueDate.ToString("dd/MM/yyyy")}- ${Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
