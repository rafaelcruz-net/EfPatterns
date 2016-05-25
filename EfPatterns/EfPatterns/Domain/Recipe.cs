using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfPatterns.Domain
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Ingredients { get; set; }
        public String Steps { get; set; }
        public Guid UserId { get; set; }
    }
}