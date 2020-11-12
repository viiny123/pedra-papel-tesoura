using game.Models.Enums;

namespace game.Helpers
{
    public interface IRuleFactory
    {
        RuleStrategy CreateRule(MoveEnum move);
    }
}