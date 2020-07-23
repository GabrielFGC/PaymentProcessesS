using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProcessosDeContratos.Entities
{
    class InstallMent
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
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
