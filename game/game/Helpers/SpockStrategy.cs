using System.Collections.Generic;
using System.Linq;
using game.Models;
using game.Models.Enums;
using game.Models.Responses;

namespace game.Helpers
{
    public class SpockStrategy : RuleStrategy
    {
        private readonly List<MoveEnum> _movesToWinner = new List<MoveEnum> { MoveEnum.Scissors, MoveEnum.Rock };
        
        public override GameWinnerResponse ValidateRule(Game game)
        {
            var movePlayer = game.Player2.Move;
            var moveWinner = _movesToWinner.Where(x => x.Equals(movePlayer));

            if (moveWinner.Any())
                return new GameWinnerResponse
                {
                    NamePlayer = game.Player1.Name
                };

            return new GameWinnerResponse
            {
                NamePlayer = game.Player2.Name
            };
        }
    }
}