using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
	class TestaAdicionaNoComeco
	{
		static void Main(string[] args)
		{
			List<int> arrayList = new List<int>();

			long tempo = TestaAdicionaNoComeco.AdicionaNoComecoList(arrayList);
			Console.WriteLine("List: " + tempo + "ms");

			LinkedList<int> linkedList = new LinkedList<int>();

			tempo = TestaAdicionaNoComeco.AdicionaNoComecoLinkedList(linkedList);
			Console.WriteLine("LinkedList: " + tempo + "ms");
		}

		public static long AdicionaNoComecoList(IList lista)
		{

			Stopwatch sw = new Stopwatch();
			sw.Start();
			int size = 100000;
			for (int i = 0; i < size; i++)
			{
				lista.Insert(0, i);
				//Console.WriteLine(lista[i]);
			}
			sw.Stop();
			return sw.ElapsedMilliseconds;
		}

		public static long AdicionaNoComecoLinkedList(LinkedList<int> lista)
		{

			Stopwatch sw = new Stopwatch();
			sw.Start();
			int size = 100000;
			for (int i = 0; i < size; i++)
			{
				lista.AddFirst(i);
				//Console.WriteLine(lista[i]);
			}
			sw.Stop();
			return sw.ElapsedMilliseconds;
		}
	}
}
