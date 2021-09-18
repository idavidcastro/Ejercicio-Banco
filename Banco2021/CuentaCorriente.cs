using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2021
{
    public class CuentaCorriente : Cuenta
    {
        private decimal cupo;
        
        public CuentaCorriente(decimal cupo, decimal _saldo)
        {
            
        }
        public override void Consignar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
