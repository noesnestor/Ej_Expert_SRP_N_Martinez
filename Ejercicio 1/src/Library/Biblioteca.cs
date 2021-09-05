using System;

namespace SRP
{
    public class Biblioteca
    {
        
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Biblioteca(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;    
        }

        public void AlmacenarLibro(Libro libro)
        {
            Console.WriteLine($"El libro {libro} se almacenó en el sector {this.SectorBiblioteca}, estantería {this.EstanteBiblioteca}");
        }

    }
}