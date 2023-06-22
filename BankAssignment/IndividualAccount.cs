using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    public class IndividualAccount : Accounts
    {
        public double First_Three_months_Interest_Rate
        {
            get { return First_Three_months_Interest_Rate; }
            set { First_Three_months_Interest_Rate = 0; }
        }
    }
}
