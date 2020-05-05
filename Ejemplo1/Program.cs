
using System.Diagnostics.CodeAnalysis;

class MainClass
{
	public static void Sumar(double x, double y)
	{
		double resultado = 0;
		resultado = x + y;
		System.Console.WriteLine("la suma es: " + resultado);
	}
	public static void exprecion(double a, double b, double c)
	{
		double resultado=0;
		resultado = ((b * b) - (4 * a * c)) / (2 * a);
		System.Console.WriteLine("La expresion es: " + resultado);

	}
	public static void Main(string[] args)
	{
		string selec;
		double a = 4, b = 3, c = 10; 
		System.Console.WriteLine("Ingrese opcion 1 para suma, de lo contrario mostrara exprecion");
		selec = System.Console.ReadLine();
		if(selec == "1")
		{
			Sumar(a,b); 
		}
		else
		{
			exprecion(a, b, c);
		}
	
	}
}
