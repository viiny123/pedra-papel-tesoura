using game.Helpers;
using game.Models;
using game.Models.Responses;

namespace game.Services
{
    public class GameService : IGameService
    {
        private readonly IRuleFactory _ruleFactory;

        public GameService(IRuleFactory ruleFactory)
        {
            _ruleFactory = ruleFactory;
        }
        
        public GameWinnerResponse RunGame(Game game)
        {
            var ruleStrategy = _ruleFactory.CreateRule(game.Player1.Move);
            var gameWinner = ruleStrategy.ValidateRule(game);
            
            return gameWinner;
        }
    }
}