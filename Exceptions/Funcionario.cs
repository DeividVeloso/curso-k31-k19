using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
	class Funcionario
	{
		private double salario;

		public void AumentaSalario(double aumento)
		{
			if (aumento < 0)
			{
				ArgumentException erro = new ArgumentException();
				throw erro;
			}
		}

	}
}
