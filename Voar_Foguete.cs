using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public class Voar_Foguete : Padrao_Voaveis
    {

		private double velocidade;

		public Voar_Foguete()
		{
			velocidade = 1000;
		}

		public string Voar()
		{
			return "Voando como um foguete. Velocidade: " + getVelocidade();
		}

		public double getVelocidade()
		{
			return velocidade;
		}

	}
}
