using game.Models;
using game.Models.Responses;

namespace game.Helpers
{
    public abstract class RuleStrategy
    {
        public abstract GameWinnerResponse ValidateRule(Game game);
    }
}