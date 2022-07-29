namespace WebApplication1.Interface.Service
{
    public interface IEntityService<T>
    {
        public IList<T> GetLastName(string lastName);
    }
}
