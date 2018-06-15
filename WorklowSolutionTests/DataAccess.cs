using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using BusinessObject.DtoModels;

namespace WorklowSolutionTests
{
    [TestClass]
    public class DataAccess
    {
        [TestMethod]
        public void Adding_New_Game()
        {
            Game game = new Game()
            {
                Guess = 10,
                Id = Guid.NewGuid(),
                MaxNumber = 10,
                Result = "Perfect",
                Turns = 2,
                WorkflowType = "Workflow"
            };

            using (var dbContext = new DataContext())
            {
                dbContext.Game.Add(game);
                dbContext.SaveChanges();

                Assert.IsNotNull(dbContext.Game.Find(game.Id), "No entry in the DB");
            }
        }
    }
}
