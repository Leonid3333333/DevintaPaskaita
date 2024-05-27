using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita
{
    public class DebitAccount : Account, IPaymentMethod
    {
        public DebitAccount(string ownerName, double openingBalance)
            : base(ownerName, openingBalance)
        {
        }

        public void Pay(double amount)
        {
            if (CheckBalance(amount))
            {
                Balance -= amount;
                Console.WriteLine($"Payment of {amount} successful. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds for payment of {amount}. Current balance: {Balance}");
            }
        }

        public bool CheckBalance(double amount)
        {
            return Balance >= amount;
        }
    }
}
