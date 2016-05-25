using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfPatterns.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public DateTime DtNascimento { get; set; } 
        public virtual IList<Recipe> Recipes { get; set; }
    }
}