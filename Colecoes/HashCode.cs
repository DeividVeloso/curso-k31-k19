using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
	class HashCode
	{
		static void Main(string[] args)
		{
			Conta conta1 = new Conta() { Numero = 20, Saldo = 100 };
			Conta conta2 = new Conta() { Numero = 20, Saldo = 100 };

			Console.WriteLine("HasCode da conta 1: {0}", conta1.GetHashCode());
			Console.WriteLine("HasCode da conta 2: {0}", conta2.GetHashCode());


			Console.WriteLine(conta1.Equals("Ola")); // false
			Console.WriteLine(conta1.Equals(null)); // false
			Console.WriteLine(conta1.Equals(conta1)); // true
			Console.WriteLine(conta1.Equals(conta2)); // true

			var contas = new HashSet<Conta>();
			contas.Add(conta1);
			contas.Add(conta2);

			Console.WriteLine(contas.Count); //1

		}
	}
}
