using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    public class DepositAcct : Accounts
    {
        //public double DepositMoney { get; set; }
        //public double WithdrawMoney { get; set; }
        public double Zero_Interest_Rate 
        { 
            get { return Zero_Interest_Rate; }
            set { Zero_Interest_Rate =  999; }
        }
    }
}
