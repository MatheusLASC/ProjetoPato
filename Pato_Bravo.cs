using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public class Pato_Bravo : Pato
    {
    public Pato_Bravo()	
	{
		setComportamento(new Voaveis_Asa());		
	}
	
	public string Mostrar() {		
		return "Eu sou o Pato Bravo.";
	}

	public string Grasnar() {
		return "Que-Que. Grrrrrrrrr.";
	}

    }
}
