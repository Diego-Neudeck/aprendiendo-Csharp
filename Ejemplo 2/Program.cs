using System;

namespace Ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ccuenta cuenta01 = new Ccuenta();
            cuenta01.Nombre = "un nombre";
            cuenta01.Cuenta = "una cuenta";
            cuenta01.TipoDeInteres = 2.5;

            cuenta01.Ingreso(12000);
            cuenta01.Reintegro(3000);

            System.Console.WriteLine(cuenta01.Nombre);
            System.Console.WriteLine(cuenta01.Cuenta);
            System.Console.WriteLine(cuenta01.Saldo);
            System.Console.WriteLine(cuenta01.TipoDeInteres);
        }
    }
}
