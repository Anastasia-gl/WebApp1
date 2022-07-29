using WebApplication1.Interface.Service;
using WebApplication1.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Service
{
    public class MovieStore : IMovieShowStore<Movie>
    {
        private readonly AppContext _dbContext;

        public MovieStore(AppContext appContext)
        {
            _dbContext = appContext;
        }

        public async Task AddAsync(Movie movie)
        {
            _dbContext.Add(movie);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Movie movie)
        {
            _dbContext.Remove(movie);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditAsync(Movie movie)
        {
            if (movie != null)
            {
                _dbContext.Movie.Update(movie);
            }

            await _dbContext.SaveChangesAsync();
        }

        public IList<Movie> GetEntityGenre()
        {
            return _dbContext.Movie.Include(m => m.Genres).ToList();
        }

        public async Task<IList<Movie>> GetEntityYear()
        {
            return await _dbContext.Movie.ToListAsync();
        }
    }
}
