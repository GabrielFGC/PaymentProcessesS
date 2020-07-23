using System;
using System.Globalization;
using ProcessosDeContratos.Entities;
using ProcessosDeContratos.Entities.Services;

namespace ProcessosDeContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: $");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractSystem contractSystem = new ContractSystem(new RandomBank());
            contractSystem.ProcessPayment(contract,months);

            Console.WriteLine("\nInstallments");

            foreach (InstallMent item in contract.InstallMents)
            {
                Console.WriteLine(item);
            }


        }
    }
}
