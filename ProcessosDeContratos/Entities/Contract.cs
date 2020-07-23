using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessosDeContratos.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double totalValue { get; set; }
        public List<InstallMent> InstallMents { get; set; } = new List<InstallMent>();

        public Contract(int number, DateTime date, double valueTotal)
        {
            Number = number;
            Date = date;
            totalValue = valueTotal;
        }



    }
}
