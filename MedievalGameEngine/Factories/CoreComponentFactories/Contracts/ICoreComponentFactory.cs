using MedievalGameEngine.Engine.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Factories.CoreComponentFactories.Contracts
{
    public interface ICoreComponentFactory
    {
        public ICoreComponent GetDefaultProcessingComponent();

        public ICoreComponent GetDefaultUpdateComponent();

        public ICoreComponent GetDefaultRendererComponent();

    }
}
