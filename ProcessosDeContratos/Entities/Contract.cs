using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessosDeContratos.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double totalValue { get; private set; }
        public List<InstallMent> InstallMents { get; private set; } = new List<InstallMent>();

        public Contract(int number, DateTime date, double valueTotal)
        {
            Number = number;
            Date = date;
            totalValue = valueTotal;
        }



    }
}
