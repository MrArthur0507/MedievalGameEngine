using MedievalGameEngine.Engine.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Implementation
{
    public class Engine : IEngine
    {
        public ICoreComponent ExecutionFlow { get; }

        public Engine(ICoreComponent firstCoreComponent) {
            ExecutionFlow = firstCoreComponent;
        }

    }
}
