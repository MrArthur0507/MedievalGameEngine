using MedievalGameEngine.EntityComponentSystem.Core.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.EntityComponentSystem.Core.EntityManager
{
    public class EntityManager : IEntityManager
    {
        private Dictionary<Guid, Dictionary<Type, IComponent>> _entities = new();

        public IEntity RegisterEntity(IEntity entity)
        {
            _entities[entity.Id] = new Dictionary<Type, IComponent>();
            return entity;
        }

        public void AddComponent<T>(IEntity entity, T component) where T : IComponent
        {
            var components = _entities[entity.Id];
            components[typeof(T)] = component;
        }

        public Dictionary<Type, IComponent> GetComponents(IEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
