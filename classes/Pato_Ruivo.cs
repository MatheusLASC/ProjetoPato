using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoPato.interfaces;

namespace ProjetoPato.classes
{
    public class Pato_Ruivo: Pato, Padrao_Grasnar
    {
        public Pato_Ruivo() { setComportamento(new Voaveis_Asa()); }

        public override string mostrar() { return "Eu sou o Pato Ruivo."; }

        public String grasnar() { return "Que-Que."; }
    }
}
