namespace CoreEscuela.Entidades
{
    class Escuela {

      string nombre;
      public string Nombre{//esto es getter & setters 
          get{return "copia "+nombre;}
          set{nombre = value.ToUpper() ;}
      }
      public int añoCreacion{get;set;} /*  manera automatica de hacer los setters*/
      public  string Ciudad { get; set; }


      //CONSTRUCTOR
      public Escuela(string nombre){
          this.Nombre=nombre;
      }
    }
}