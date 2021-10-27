using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPato.classes
{
    public class Pato_Borracha : Pato
    {
        public Pato_Borracha() { setComportamento(new Nao_Voa()); }

        public override String mostrar() { return "Olá, eu sou de Borracha."; }
    }
}
