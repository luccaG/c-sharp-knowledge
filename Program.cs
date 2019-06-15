using System;

namespace CoreEscuela
{
    class Escuela{
        public string nombre;
         public string direccion;

        public int añoFundacion;
         public void Timbrar(){
            //todo
            Console.Beep(2000 ,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             var escuelita = new Escuela();
             escuelita.nombre="ROsthwood";
             escuelita.direccion="Monte Coman 561 ";     
             escuelita.añoFundacion=2003;
             Console.WriteLine(" timbre");
             escuelita.Timbrar();
             
                }
    }
}
