using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita
{
    public interface IPaymentMethod
    {
        void Pay(double amount);
        bool CheckBalance(double amount);
    }
}
