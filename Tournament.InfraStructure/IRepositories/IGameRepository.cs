using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Model.Models;

namespace Tournament.InfraStructure.IRepositories
{
    public interface IGameRepository
    {
        List<Game>? GetAll();
        Game GetById(int id);
        void Add(Game game);
        void Delete(int  id);   
        void Update(int id,Game game);
    }
}
