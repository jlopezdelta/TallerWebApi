using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Book: BaseEntity
    {
        public string Titulo { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public int NumeroDePaginas { get; set; }
        public decimal Precio { get; set; }
        public bool Disponibilidad { get; set; }
        public int AutorId  { get; set; }
        public Editorial Editorial { get; set; }
        public int EditorialId { get; set; }
        public Category Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
