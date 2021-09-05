using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /*
        Si quisiéramos agregarle a la clase libro la capacidad de registrar si es una edición especial 
        del mismo, tendríamos que modificar la clase "Libro". Y si quisiéramos cambiar el tipo
        de almacenamiento de físico a digital, también habría que cambiar a la clase. Debido a esto, 
        la clase "Libro" no cumple con las normas SRP y por ende habría que hacer que el método 
        "AlmacenarLibro" sea una clase separada que colabore con la clase "Libro". 
        */
        
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
