using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2021
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(decimal _saldo)
        {
            saldo = _saldo;
        }
        public override void Consignar(decimal valor)
        {
            saldo += valor; 
        }
        public override void Retirar(decimal valor)
        {
            saldo -= valor;
        }
    }
}
