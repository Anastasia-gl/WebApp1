using WebApplication1.Interface.Model;
namespace WebApplication1.Interface.Service
{
    public interface IWatchService<T>
    {
        public IList<T> GetGenre(string title);

        public Task<IList<T>> GetYear(int year);
    }
}
