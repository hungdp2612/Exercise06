using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Account
    {
        private int MONEY;
        public Account(int amount)
        {
            MONEY = amount;
        }
        public void Deposit(int amount)
        {
            MONEY += amount;
        }
        public void Withdraw(int amount)
        {
            MONEY -= amount;
        }
        public int Balance()
        {
            return MONEY;
        }
    }
}
