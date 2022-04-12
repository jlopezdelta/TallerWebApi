using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Category:BaseEntity
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public ICollection<AuthorCategory> AuthorCategory { get; set; } = new List<AuthorCategory>();

    }
}
