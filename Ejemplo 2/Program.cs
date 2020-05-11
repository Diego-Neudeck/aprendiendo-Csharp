using System;

namespace Ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ccuenta cuenta01 = new Ccuenta();
            System.Console.WriteLine("Ingrese nombre: ");
            cuenta01.Nombre = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese Cuenta: ");
            cuenta01.Cuenta = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese el interes: ");
            cuenta01.TipoDeInteres = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Introduzca ingreso:");
            cuenta01.Ingreso(Convert.ToDouble(Console.ReadLine()));
            System.Console.WriteLine("Introduzca reintegro: ");
            cuenta01.Reintegro(Convert.ToDouble(Console.ReadLine()));

            System.Console.WriteLine("------------------------------");

            System.Console.WriteLine("Nombre cuenta: " + cuenta01.Nombre);
            System.Console.WriteLine("Cuenta: " + cuenta01.Cuenta);
            System.Console.WriteLine("Saldo: " +cuenta01.Saldo);
            System.Console.WriteLine("Interes: " + cuenta01.TipoDeInteres);
        }
    }
}
