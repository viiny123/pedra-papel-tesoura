using game.Models;
using game.Models.Responses;

namespace game.Services
{
    public interface IGameService
    {
        GameWinnerResponse RunGame(Game game);
    }
}