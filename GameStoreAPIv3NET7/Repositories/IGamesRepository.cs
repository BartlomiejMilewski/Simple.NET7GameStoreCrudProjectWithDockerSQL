using GameStoreAPIv3NET7.Entities;

namespace GameStoreAPIv3NET7.Repositories
{
    public interface IGamesRepository
    {
        Task CreateAsync(Game game);
        Task DeleteAsync(int id);
        Task<Game?> GetAsync(int id);
        Task<IEnumerable<Game>> GetAllAsync();
        Task UpdateAsync(Game updatedGame);
    }
}