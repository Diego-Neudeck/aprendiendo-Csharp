class MainClass
{
	public static void Main(string[] args)
	{
		int dato1, dato2, resultado;
		dato1 = 10;
		dato2 = 20;
		resultado = dato1 - (dato2 / dato1);
		//	System.Console.WriteLine ("Hello World!");
		System.Console.WriteLine("el resultado es: {0}-({1}/{0})={2}", dato1, dato2, resultado);
	}
}
