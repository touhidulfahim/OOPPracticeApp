using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeApp.Models
{
    public class Amount : Account
    {

        public override string Withdraw(double amount)
        {
            if (Balance - amount>=0)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Failed";
            }
        }

    }
}
