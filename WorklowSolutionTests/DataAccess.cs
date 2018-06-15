using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using BusinessObject.DtoModels;
using BusinessLogic.Services;

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

            IGameService gameService = new GameService();

            var result = gameService.CreateGame(game);

            Assert.IsNotNull(result, "No entry in the DB");
        }
    }
}
