using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoanManager regularLoanManager = new RegularLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RequestManager requestManager = new RequestManager();
            requestManager.Request(housingLoanManager,databaseLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() {regularLoanManager };
            requestManager.LoanInforming(loans);
        }
    }
}
