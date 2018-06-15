using BusinessObject.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IGameService
    {
        Game CreateGame(Game game);
        Game UpdateGame(Game game);
        void DeleteGame(Guid game);
        Game GetGame(Guid game);
    }
}
