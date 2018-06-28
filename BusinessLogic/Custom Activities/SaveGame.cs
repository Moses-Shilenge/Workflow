using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using BusinessObject.DtoModels;
using BusinessLogic.Services;

namespace BusinessLogic.Custom_Activities
{

    public sealed class SaveGame : CodeActivity<Game>
    {
        // Define an activity input argument of type string
        public InArgument<Game> Game { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override Game Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            var text = context.GetValue(Game);

            GameService _gameService = new GameService();

            return _gameService.CreateGame(text);
        }
    }
}
