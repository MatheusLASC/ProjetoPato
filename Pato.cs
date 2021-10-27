using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato
{
    public abstract class Pato
    {
        protected Padrao_Voaveis comportamento_pato;

        public string Nadar()
        {
            return "Pato Nadando.";
        }
        public void setComportamento(Padrao_Voaveis padrao)
        {
            comportamento_pato = padrao;
        }

        public string Comportamento_pato()
        {
            return comportamento_pato.Voar();
        }
    }
}
