using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoPato.interfaces;

namespace ProjetoPato.classes
{
    public class Pato_Bravo : Pato, Padrao_Grasnar
    {
        public Pato_Bravo() { setComportamento(new Voaveis_Asa()); }

        public override String mostrar() { return "Eu sou o Pato Bravo"; }

        public String grasnar() { return "Que-Que. Grrrrrrrr"; }
    }
}
