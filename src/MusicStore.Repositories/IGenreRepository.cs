
using MusicStore.Entities;
namespace MusicStore.Repositories;

public interface IGenreRepository
{
    Task<List<Genre>> GetAsync();
    Task<Genre?> GetAsync(int id);
    Task<int> AddAsync(Genre genre);
    Task UpdateAsync(int id, Genre genre);

    Task DeleteAsync (int id);
}
