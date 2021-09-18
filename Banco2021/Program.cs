using System;

namespace Banco2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al cajero automático");
            Cuenta cuenta = new CuentaAhorro(50000);
            
            cuenta.Consignar(100000);
            Console.WriteLine(cuenta.ConsultarSaldo());
            Console.ReadKey();
        }
    }


}
