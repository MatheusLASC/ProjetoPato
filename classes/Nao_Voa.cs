using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoPato.interfaces;

namespace ProjetoPato.classes
{
    public class Nao_Voa : Padrao_Voaveis
    {
        public Nao_Voa() { }

        public String voar() { return $"Esse patoo não Voa. Velocidade: {getVelocidade()}"; }

        public double getVelocidade() { return 0; }
    }
}
