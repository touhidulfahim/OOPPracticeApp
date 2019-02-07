using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeApp.Models
{
    public class Account
    {
        public string AccountNo { get; set; }
        public double Balance { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Success";
        }
    }
}
