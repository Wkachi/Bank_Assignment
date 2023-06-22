using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    public abstract class Accounts
    {
        public string CustomerName { get; set; }
        public double CustomerAccountBalance { get; set; }

        public double CustomerInterestRate { get; set; }

        public double DepositMoney { get; set; }
        public double WithdrawMoney { get; set; }

    public double Number_Of_Months 
        {
            get { return Number_Of_Months; }
            set { Number_Of_Months = Number_Of_Months; }
        }

        public double Interest_Rate
        {
            get { return Interest_Rate; }
            set { Interest_Rate = Interest_Rate; }
        }

        public  double CalculateInterest()
        {
            return Number_Of_Months * Interest_Rate;
        }

    }
}
