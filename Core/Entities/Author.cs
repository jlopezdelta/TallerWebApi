using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Author : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Book Book { get; set; }
        public ICollection<AuthorCategory> AuthorCategory { get; set; } = new List<AuthorCategory>();
    }
}
