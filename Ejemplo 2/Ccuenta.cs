using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_2
{
    class Ccuenta
    {



        //atributos
        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInteres;

        //propiedades y metodos


        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Length == 0)
                {
                    System.Console.WriteLine("ERROR, nombre no valido");
                    return;
                }
                nombre = value;
            }
        }


        public string Cuenta
        {
            get { return cuenta; }
            set
            {
                if (value.Length == 0)
                {
                    System.Console.WriteLine("Error, cuenta no valida");
                    return;
                }
                cuenta = value;
            }
        }
        public double Saldo
        {
            get { return saldo; }
        }


        public void Ingreso(double cantidad)
        {
            if (cantidad < 0)
            {
                System.Console.WriteLine("Error, cantidad negativa");
                return;
            }
            saldo = saldo + cantidad;
        }

        public void Reintegro(double cantidad)
        {
            if (saldo - cantidad < 0)
            {
                System.Console.WriteLine("Error, no dispone de saldo");
                return;
            }
            saldo = saldo - cantidad;
        }


        public double TipoDeInteres
        {
            get { return tipoDeInteres; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Error, tipo no valido");
                    return;
                }
                tipoDeInteres = value;
            }
        }




    }
}
