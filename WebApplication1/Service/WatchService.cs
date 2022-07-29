using WebApplication1.Interface.Service;
using WebApplication1.Interface.Model;
using WebApplication1.Model;
namespace WebApplication1.Service
{
    public class WatchService<T> : IWatchService<T> where T : IMovieShow
    {
        private readonly IMovieShowStore<T> _store;

        public WatchService(IMovieShowStore<T> store)
        {
            _store = store;
        }

        public IList<T> GetGenre(string title)
        {
            return _store.GetEntityGenre().Where(a => a.Genres.Title == title).ToList();
        }

        public async Task<IList<T>> GetYear(int year)
        {
            var list = await _store.GetEntityYear();
            return list.Where(a => a.Year == year).ToList();
        }
    }
}
