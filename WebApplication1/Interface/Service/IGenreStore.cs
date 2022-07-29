using WebApplication1.Model;
namespace WebApplication1.Interface.Service
{
    public interface IGenreStore
    {
        public async Task AddAsync(Genre genre) { }

        public async Task RemoveAsync(Genre genre) { }

        public async Task EditAsync(Genre genre) { }
    }
}
