using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreAPIv3NET7.Entities;

namespace GameStoreAPIv3NET7.Repositories
{
    public class InMemGamesRepository : IGamesRepository
    {
        private readonly List<Game> games = new()
{
    new Game()
    {
        Id = 1,
        Name = "SC Brood War",
        Genre = "Strategy",
        Price = 9.99M,
        ReleaseDate = new DateTime(1997, 2, 1),
        ImageUri = "https://placehold.co/100"
    },
    new Game()
    {
        Id = 2,
        Name = "SC 2",
        Genre = "Strategy",
        Price = 49.99M,
        ReleaseDate = new DateTime(2012, 2, 1),
        ImageUri = "https://placehold.co/150"
    }
};

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await Task.FromResult(games);
        }

        public async Task <Game?> GetAsync(int id)
        {
            return await Task.FromResult(games.Find(game => game.Id == id));
        }

        public async Task CreateAsync(Game game)
        {
            game.Id = games.Max(game => game.Id) + 1;
            games.Add(game);

            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Game updatedGame)
        {
            var index = games.FindIndex(game => game.Id == updatedGame.Id);
            games[index] = updatedGame;

            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var index = games.FindIndex(game => game.Id == id);
            games.RemoveAt(index);

            await Task.CompletedTask;
        }
    }
}