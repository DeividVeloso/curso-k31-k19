using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
	class Numeros
	{
		delegate bool Filtro(int numero);

		static void Main(string[] args)
		{
			int[] numeros = { 1, 2, 3, 7, 8, 10 };

			Filtro filtraPar = numero => numero % 2 == 0;

			Filtro filtroImpar = numero => numero % 2 == 1;

			Console.WriteLine("Numeros Pares:");
			Numeros.ImprimeNumeros(numeros, filtraPar);

			Console.WriteLine("Numeros Impares:");
			Numeros.ImprimeNumeros(numeros, filtroImpar);
		}

		static void ImprimeNumeros(int[] numeros, Filtro filtro)
		{
			foreach (var numero in numeros)
			{
				if (filtro(numero))
				{
					Console.Write(" {0} ", numero);
				}
			}
			Console.WriteLine();
		}
	}
}
