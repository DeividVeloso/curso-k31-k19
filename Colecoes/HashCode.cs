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
		
			Console.WriteLine(conta1.Equals(conta2));


		}
	}
}
