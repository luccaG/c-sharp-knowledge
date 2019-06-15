using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{     class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela();
            escuela.Nombre="Norman Olbrick";
            Console.WriteLine(escuela.Nombre);


        }
             
    }
}
