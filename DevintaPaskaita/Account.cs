using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita
{
    public class Account
    {
        public string OwnerName { get; set; }
        protected double Balance;

        public Account(string ownerName, double openingBalance)
        {
            OwnerName = ownerName;
            Balance = openingBalance;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
