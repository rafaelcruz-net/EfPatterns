using EfPatterns.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfPatterns.Domain.Repository
{
    public class RecipeRepository : BaseContext<Recipe>, IUnitOfWork<Recipe>
    {

    }
}