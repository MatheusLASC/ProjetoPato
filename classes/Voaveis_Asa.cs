using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoPato.interfaces;

namespace ProjetoPato.classes
{
    public class Voaveis_Asa : Padrao_Voaveis
    {
        private double velocidade;

        public Voaveis_Asa() { velocidade = 10; }

        public String voar() { return $"Voando como um passáro que voa. Velocidade: {getVelocidade()}"; }

        public double getVelocidade() { return velocidade; }
    }
}
