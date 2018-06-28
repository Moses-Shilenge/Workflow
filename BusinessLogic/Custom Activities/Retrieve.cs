using BusinessLogic.Services;
using BusinessObject.DtoModels;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Custom_Activities
{
    public sealed class Retrieve : CodeActivity<Game>
    {
        // Define an activity input argument of type string
        public InArgument<string> GameID { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override Game Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            var gameId = Guid.Parse(context.GetValue(GameID));

            GameService _gameService = new GameService();

            return _gameService.GetGame(gameId);
        }
    }
}
