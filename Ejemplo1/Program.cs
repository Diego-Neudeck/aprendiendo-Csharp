
using System.Diagnostics.CodeAnalysis;

class MainClass
{
	public static void Sumar(double x, double y,double z)
	{
		double resultado = 0;
		resultado = x + y + z;
		System.Console.WriteLine();
		System.Console.WriteLine("la suma es: " + resultado);
	}
	public static void exprecion(double a, double b, double c)
	{
		double resultado=0;
		resultado = ((b * b) - (4 * a * c)) / (2 * a);
		System.Console.WriteLine();
		System.Console.WriteLine("La expresion es: " + resultado);
	}
	public static void Main(string[] args)
	{
		string selec;
		double a = 4, b = 3, c = 10; 
		do
		{
			System.Console.WriteLine("1-Suma a + b + c");
			System.Console.WriteLine("2-Se realiza (b^2-4*a*c)/(2*a)");
			System.Console.WriteLine("s-Salir");
			selec = System.Console.ReadLine();
			switch (selec)
			{
				case "1":
					Sumar(a,b,c);
					break;
				case "2":
					exprecion(a, b, c);
					break;
				/*default:
					{
						if(selec!="s") 
						System.Console.WriteLine("Digito incorrecto");
					}*/
			}
			System.Console.WriteLine("--------------------------");
		} while (selec!="s");
		System.Console.WriteLine("Programa finalizado");
	}
}
