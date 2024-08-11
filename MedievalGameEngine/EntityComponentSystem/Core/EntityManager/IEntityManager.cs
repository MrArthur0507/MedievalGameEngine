using MedievalGameEngine.EntityComponentSystem.Core.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.EntityComponentSystem.Core.EntityManager
{
    public interface IEntityManager
    {
        public IEntity RegisterEntity(IEntity entity);

        public void AddComponent<T>(IEntity entity, T component) where T : IComponent;

        public Dictionary<Type, IComponent> GetComponents(IEntity entity);
    }
}
