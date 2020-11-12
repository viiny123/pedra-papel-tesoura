using System;
using game.Models.Enums;

namespace game.Helpers
{
    public class RuleFactory : IRuleFactory
    {
        public RuleStrategy CreateRule(MoveEnum move)
        {
            switch (move)
            {
                case MoveEnum.Rock:
                    return new RockStrategy();
                case MoveEnum.Paper:
                    return new PaperStrategy();
                case MoveEnum.Scissors:
                    return new ScissorsStrategy();
                case MoveEnum.Lizard:
                    return new LizardStrategy();
                case MoveEnum.Spock:
                    return new SpockStrategy();
                default:
                    throw new ArgumentOutOfRangeException(nameof(move), move, "Argumento inválido");
            }
        }
    }
}