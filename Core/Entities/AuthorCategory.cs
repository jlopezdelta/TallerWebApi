using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class AuthorCategory
    {
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Status { get; set; }
    }
}
