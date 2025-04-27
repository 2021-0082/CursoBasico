internal class Program
{
	private static void Main(string[] args)
	{
		
		Console.WriteLine("Elige una opción:");
		Console.WriteLine("1. Dividir dos números");
		Console.WriteLine("2. Multiplicar dos números");
		Console.WriteLine("3. Resolver una ecuación cuadrática");
		Console.WriteLine("4. Verificar si un número es primo");
		Console.WriteLine("5. Imprimir números impares del 1 al 30");
		Console.WriteLine("6. Imprimir secuencia de Fibonacci del 1 al 50");

		Console.Write("Ingresa el número de la opción que deseas: ");
		int opcion = Convert.ToInt32(Console.ReadLine());

		switch (opcion)
		{
			case 1:
				DividirDosNumeros();
				break;
			case 2:
				MultiplicarDosNumeros();
				break;
			case 3:
				ResolverEcuacionCuadratica();
				break;
			case 4:
				EsPrimo();
				break;
			case 5:
				NumerosImpares();
				break;
			case 6:
				Fibonacci();
				break;
			default:
				Console.WriteLine("Opción inválida.");
				break;
		}

		Console.WriteLine("Presiona cualquier tecla para salir...");
		Console.ReadKey();
	}


	static void MultiplicarDosNumeros()
	{
		Console.WriteLine("\t Multiplicar dos numeros \n");

		Console.WriteLine("Ingresa el primer número:");
		double numero1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Ingresa el segundo número:");
		double numero2 = Convert.ToDouble(Console.ReadLine());


		double resultado = numero1 * numero2;
		Console.WriteLine($"El resultado de multiplicar {numero1} y {numero2} es: {resultado}");

	}


	static void DividirDosNumeros()
	{
		Console.WriteLine("\t Dividir dos numeros \n");

		Console.WriteLine("Ingresa el primer número:");
		double numero1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Ingresa el segundo número:");
		double numero2 = Convert.ToDouble(Console.ReadLine());

		if (numero2 != 0)
		{
			double resultado = numero1 / numero2;
			Console.WriteLine($"El resultado de dividir {numero1} entre {numero2} es: {resultado}");
		}
		else
		{
			Console.WriteLine("Error: No se puede dividir entre cero.");
		}
	}


	static void ResolverEcuacionCuadratica()
	{

		Console.Write("Ingresa el valor de a: ");
		int a = Convert.ToInt32(Console.ReadLine());

		Console.Write("Ingresa el valor de b: ");
		double b = Convert.ToDouble(Console.ReadLine());

		Console.Write("Ingresa el valor de c: ");
		double c = Convert.ToDouble(Console.ReadLine());

		double discriminante = b * b - 4 * a * c;

		if (discriminante > 0)
		{
			double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
			double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
			Console.WriteLine($"Las soluciones son: x1 = {x1} y x2 = {x2}");
		}
		else if (discriminante == 0)
		{
			double x = -b / (2 * a);
			Console.WriteLine($"Hay una única solución: x = {x}");
		}
		else
		{
			Console.WriteLine("No hay soluciones reales (el discriminante es negativo).");
		}
	}

	static void EsPrimo()
	{
		Console.WriteLine("Ingresa un número para verificar si es primo:");
		int numero = Convert.ToInt32(Console.ReadLine());

		if (numero <= 1)
		{
			Console.WriteLine($"{numero} no es un número primo.");
			return;
		}


		for (int i = 2; i <= Math.Sqrt(numero); i++)
		{
			if (numero % i == 0)
			{
				Console.WriteLine($"{numero} no es un número primo.");
			}
			else
			{
				Console.WriteLine($"{numero}  es un número primo.");
			}
			return;
		}

	}

	static void NumerosImpares(){
		for (int i = 1; i <= 30; i++)
		{
			if (i % 2 != 0)
			{
				Console.WriteLine(i);
			}
		}
	}
	static void Fibonacci(){
		Console.WriteLine("Secuencia de Fibonacci del 1 al 50:");

		int a = 0;
		int b = 1;

		while (b <= 50)
		{
			Console.WriteLine(b);
			int temp = b;
			b = a + b;
			a = temp;
		}

	}

}