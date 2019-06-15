using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{     class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Norman Olbrick", 2001);
             escuela.Pais="Argentina";
             escuela.Ciudad="Claypole";
             escuela.TipoEscuela=TiposEscuela.Primaria;
            Console.WriteLine(escuela);
            


        }
             
    }
}
