using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}
