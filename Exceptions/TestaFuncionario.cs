using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class TestaFuncionario
	{
		static void Main(string[] args)
		{

			Funcionario f = new Funcionario();
			try
			{
				f.AumentaSalario(-1000);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(" Houve uma ArgumentException ao aumentar o salário ");
			}
		}
	}
}
