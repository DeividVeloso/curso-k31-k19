using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
	class TestaAdicionaNoFinal
	{
		private static void Main(string[] args)
		{
			List<int> arrayList = new List<int>();

			long tempo = TestaAdicionaNoFinal.AdicionaNoFinal(arrayList);
			Console.WriteLine("List: " + tempo + "ms");

			LinkedList<int> linkedList = new LinkedList<int>();

			tempo = TestaAdicionaNoFinal.AdicionaNoFinal(linkedList);
			Console.WriteLine("LinkedList: " + tempo + "ms");
		}

		public static long AdicionaNoFinal(ICollection<int> lista)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			int size = 100000;

			for (int i = 0; i < size; i++)
			{
				lista.Add(i);
				//Console.WriteLine(lista[i]);
			}
			sw.Stop();

			//Console.WriteLine(lista.Count);

			return sw.ElapsedMilliseconds;


		}
	}
}
