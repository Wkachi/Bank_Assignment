using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    public class LoanAcct : Accounts 
    {
        public double Interest_Rate
        {
            get { return Interest_Rate; }
            set { Interest_Rate = 0; }
        }
    }
}
