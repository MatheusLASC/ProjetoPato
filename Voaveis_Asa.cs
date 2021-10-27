using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public class Voaveis_Asa : Padrao_Voaveis
    {
     
     private double velocidade;

	public Voaveis_Asa() {
		velocidade = 10;
	}

	public String Voar() {
		return "Voando como um pássaro que voa. Velocidade: " + getVelocidade();
	}

	public double getVelocidade() {
		return velocidade;
	}
	
    }
}
