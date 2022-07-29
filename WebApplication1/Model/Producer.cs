using WebApplication1.Interface.Model;
namespace WebApplication1.Model
{
    public class Producer : IActorProducer
    {
        public Producer(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;
        }

        public int Id { get; set; }

        public string FisrtName { get; set; }

        public string LastName { get; set; }

        public IList<Cast> Cast { get; set; }
    }
}
