using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public class Pato_Borracha : Pato
    {
     public Pato_Borracha()
	{
		setComportamento(new Nao_Voa());		
	}
	
	public string Mostrar() {
		return "Olá, sou de Borracha";
	}
	
    }
}
