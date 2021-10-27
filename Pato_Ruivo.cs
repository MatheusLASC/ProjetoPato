using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public class Pato_Ruivo : Pato
    {
    public Pato_Ruivo()	
	{
		setComportamento(new Voar_Foguete());		
	}
	
	public string Mostrar() {
		return "Eu sou o Pato Ruivo." ;
	}

        public string Grasnar()
        {
		return 	"Que-Que.";
	}

    }
}
