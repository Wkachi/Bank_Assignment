using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    public class CompanyAccount : Accounts
    {
        public double First_Two_months_Interest_Rate
        {
            get { return First_Two_months_Interest_Rate; }
            set { First_Two_months_Interest_Rate = 0; }
        }
    }
}
