using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoPato.interfaces;

namespace ProjetoPato.classes
{
    public abstract class Pato
    {
        protected Padrao_Voaveis comportamento_pato;

        public abstract String mostrar();

        public String nadar() { return "Pato Nadando."; }

        public void setComportamento(Padrao_Voaveis padrao) { comportamento_pato = padrao; }

        public String comportamento_Pato() { return comportamento_pato.voar(); }
    }
}
