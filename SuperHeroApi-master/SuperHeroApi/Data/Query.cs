using SuperHeroApi.Models;

namespace SuperHeroApi.Data
{
    public class Query
    {
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;
    }
}
