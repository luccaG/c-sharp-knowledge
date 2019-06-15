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
             escuelita.nombre="Chinga Tu Madre";
             escuelita.direccion="A la verga ";     
             escuelita.añoFundacion=2003;
             Console.WriteLine(" a la huewva ");
             escuelita.Timbrar();
             
                }
    }
}
