using System;

using ProjetoPato.classes;

namespace ProjetoPato
{
    class Program
    {
        static void Main (string[] args)
        {
            Pato pt = new Pato_Ruivo();

            Console.WriteLine(pt.mostrar());
            Console.WriteLine(pt.nadar());
            Console.WriteLine(pt.comportamento_Pato());

            pt.setComportamento(new Voar_Foguete());

            Console.WriteLine(pt.comportamento_Pato());
        }
    }
}