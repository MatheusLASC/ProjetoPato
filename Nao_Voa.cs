using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public class Nao_Voa : Padrao_Voaveis
    {
      public Nao_Voa()
	{
			
	}	
    public string Voar() {
		return "Esse pato não Voa. Velocidade: " + getVelocidade();
	}

	public double getVelocidade() {
		return 0;
	}

    }
}
