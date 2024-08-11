using MedievalGameEngine.Engine.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Implementation
{
    public class EngineBuilder
    {
        private ICoreComponent EngineFlowFirstComponent;
        private ICoreComponent EngineFlowLastComponent;
        private IEngine EngineInstance;


        public void AddComponent(ICoreComponent component)
        {
            if (EngineFlowFirstComponent == null)
            {
                EngineFlowLastComponent = component;
                EngineFlowFirstComponent = component;
            } else
            {
                EngineFlowLastComponent.Next = component;
                EngineFlowLastComponent = EngineFlowLastComponent.Next;
            }
        }

        public IEngine Build()
        {
            EngineInstance = new Engine(EngineFlowFirstComponent);
            return EngineInstance;

        }
    }
}
