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

        [TestMethod]
        public void Updating_New_Game()
        {
            Game game = new Game()
            {
                Guess = 10,
                Id = Guid.Parse("F16EA315-6BFE-4D9D-8139-A4329C58FD8D"),
                MaxNumber = 10,
                Result = "Perfect",
                Turns = 500,
                WorkflowType = "Workflow"
            };

            IGameService gameService = new GameService();

            var result = gameService.UpdateGame(game);

            Assert.IsNotNull(result, "Updated");
        }
    }
}
