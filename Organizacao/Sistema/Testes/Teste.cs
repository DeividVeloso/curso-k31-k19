using Organizacao.Sistema.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroProjeto;

namespace Organizacao.Sistema.Testes
{
	class Teste
	{
		static void Main(string[] args)
		{
			Conta c = new Conta();
			Cliente cli = new Cliente();
			cli.ClienteID = 100;
			c.Deposita(100);
			System.Console.WriteLine("Saldo : " + c.Saldo +" ClienteID: " + cli.ClienteID);
		}
	}
}
