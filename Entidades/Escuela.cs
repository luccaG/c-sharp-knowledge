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

        public string Pais { get; set; }

        public TiposEscuela TipoEscuela{get;set;}
      //CONSTRUCTOR
      /*  PRIMERA MANERA
      public Escuela(string nombre , int año){
          this.Nombre=nombre;
          this.añoCreacion=año;
      }*/
      //SEGUNDA MANERA DE CONSTRUCCION
      public Escuela(string nombre ,int año)=>(Nombre, añoCreacion)=(nombre , año);

      // TO STRINGGGG , hago un overrride para sobreescribir el metodo toString
      public override string ToString(){
          return $"nombre : {Nombre}, tipo {TipoEscuela} \n pais {Pais} ,Ciudad : {Ciudad}" ;
      }
      
    }

}