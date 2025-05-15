using Microsoft.EntityFrameworkCore;
using Tournament.InfraStructure.Contexts;
using Tournament.InfraStructure.IRepositories;
using Tournament.Model.Models;

namespace Tournament.InfraStructure.Repositories
{
    public class EFGameRepository : IGameRepository
    {
        private readonly TourneyContext tourneyContext;
        public EFGameRepository()
        {
            tourneyContext = new TourneyContext();
        }

        public void Add(Game game)
        {
            tourneyContext.Game.Add(game);
            tourneyContext.SaveChanges();

        }

        public void Delete(int id)
        {
            var game = tourneyContext.Game.First(x => x.Id == id);
            tourneyContext.Game.Remove(game);
            tourneyContext.SaveChanges();
        }

        public List<Game>? GetAll()
        {
            return tourneyContext.Game.ToList();
        }

        public Game GetById(int id)
        {
            return tourneyContext.Game.AsNoTracking().FirstOrDefault(x => x.Id == id)!;
        }

        public void Update(int id, Game game)
        {
            tourneyContext.Game.Update(game);
            tourneyContext.SaveChanges();
        }
    }
}
