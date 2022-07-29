using WebApplication1.Model;
using WebApplication1.Interface.Service;
using WebApplication1.Interface.Model;
namespace WebApplication1.Service
{
    public class EntityService<T> : IEntityService<T> where T : IActorProducer
    {
        private readonly IActorProducerStore<T> _actorProducerStore;

        public EntityService(IActorProducerStore<T> actorProducerStore)
        {
            _actorProducerStore = actorProducerStore;
        }

        public IList<T> GetLastName(string lastName)
        {
            return _actorProducerStore.GetEntityLastName().Where(a => a.LastName==lastName).ToList();
        }
    }
}
