using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment
{
    public class MortageAcct : Accounts
    {
        public double First_Twelve_Months_Interest_Rate
        {
            get { return First_Twelve_Months_Interest_Rate; }
            set { First_Twelve_Months_Interest_Rate = 0.5; }
        }

        public double First_Six_Months_Interest_Rate
        {
            get { return First_Six_Months_Interest_Rate; }
            set { First_Six_Months_Interest_Rate = 0; }
        }
    }
}
