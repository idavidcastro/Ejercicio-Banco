using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2021
{
    public abstract class Cuenta
    {
        protected decimal saldo;

        public abstract void Consignar(decimal valor);

        public abstract void Retirar(decimal valor);

        public string ConsultarSaldo()
        {
            return $"Su saldo es: {saldo}";
        }
    }
}
