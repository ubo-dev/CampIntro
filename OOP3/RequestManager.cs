using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RequestManager
    {
        public void Request(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Calc();
            loggerService.Log();
        }

        public void LoanInforming(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calc();
            }
        }

    }
}
