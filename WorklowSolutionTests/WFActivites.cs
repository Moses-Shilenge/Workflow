using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using BusinessObject.DtoModels;
using BusinessLogic.Services;
using System.Activities;
using BusinessLogic.Custom_Activities;
using System.Collections.Generic;

namespace WorklowSolutionTests
{
    [TestClass]
    public class WFActivites
    {
        [TestMethod]
        public void Create()
        {
            Game game = new Game()
            {
                Guess = 10,
                Id = Guid.NewGuid(),
                MaxNumber = 10,
                Result = "Testing Create custom activities",
                Turns = 2,
                WorkflowType = "Workflow"
            };

            SaveGame create = new SaveGame();
            Dictionary<string, object> input = new Dictionary<string, object>();

            input.Add("Game", game);

            var result = (Game)WorkflowInvoker.Invoke(create, input);

            Assert.AreEqual<Game>(game, result);
        }

        [TestMethod]
        public void Update()
        {
            Game game = new Game()
            {
                Guess = 10,
                Id = Guid.Parse("3fd5acca-3b65-4383-b334-2f79d8f6c0db"),
                MaxNumber = 10,
                Result = "Testing Update activites",
                Turns = 500,
                WorkflowType = "Workflow"
            };

            Update create = new Update();
            Dictionary<string, object> input = new Dictionary<string, object>();

            input.Add("Game", game);

            var result = (Game)WorkflowInvoker.Invoke(create, input);

            Assert.AreNotEqual<Game>(game, result);
        }

        [TestMethod]
        public void Retrieve()
        {
            Game game = new Game()
            {
                Id = Guid.Parse("3fd5acca-3b65-4383-b334-2f79d8f6c0db"),
            };

            Retrieve retrieve = new Retrieve();
            Dictionary<string, object> input = new Dictionary<string, object>();

            input.Add("GameID", game.Id.ToString());

            var result = (Game)WorkflowInvoker.Invoke(retrieve, input);

            Assert.IsNotNull(result, "Check failed");
        }

        [TestMethod]
        public void InitiateGame()
        {
            Game game = new Game()
            {
                Guess = 10,
                Id = Guid.NewGuid(),
                MaxNumber = 10,
                Result = "Testing Update activites",
                Turns = 500,
                WorkflowType = "Workflow"
            };

            CreateBookmark initiateGame = new CreateBookmark();
            Dictionary<string, object> gameInput = new Dictionary<string, object>();

            gameInput.Add("Game", game);

            var result = (Game)WorkflowInvoker.Invoke(initiateGame, gameInput);

            Assert.IsNotNull(result, "Check failed");
        }
    }
}
