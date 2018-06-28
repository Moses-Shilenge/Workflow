using BusinessObject.DtoModels;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class GameService : IGameService
    {
        public BusinessObject.DtoModels.Game CreateGame(BusinessObject.DtoModels.Game game)
        {
            using (var dbContext = new DataContext())
            {
                dbContext.Game.Add(game);
                dbContext.SaveChanges();

                return dbContext.Game.Find(game.Id);
            }
        }

        public BusinessObject.DtoModels.Game UpdateGame(Game newGame)
        {
            using (var dbContext = new DataContext())
            {
                var updatGame = dbContext.Game.Find(newGame.Id);

                updatGame.Guess = newGame.Guess;
                updatGame.MaxNumber = newGame.MaxNumber;
                updatGame.Result = newGame.Result;
                updatGame.Turns = newGame.Turns;
                updatGame.WorkflowType = newGame.WorkflowType;

                dbContext.SaveChanges();

                return dbContext.Game.Find(updatGame.Id);
            }
        }

        public void DeleteGame(Guid game)
        {
            using (var dbContext = new DataContext())
            {

            }
        }

        public BusinessObject.DtoModels.Game GetGame(Guid id)
        {
            using (var dbContext = new DataContext())
            {
                return dbContext.Game.Find(id);
            }
        }
        
        #region
        
        public List<InstancesTable> GetInstances()
        {
            using (var dbContext = new DataContext())
            {
                return dbContext.InstancesTable.ToList();
            }
        }

        #endregion
    }
}