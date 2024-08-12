using MedievalGameEngine.Engine.Core.Contracts;
using MedievalGameEngine.Engine.Core.Implementation;
using MedievalGameEngine.Factories.CoreComponentFactories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Factories.CoreComponentFactories.Implementation
{
    public class CoreComponentFactory : ICoreComponentFactory

    {
        public ICoreComponent GetDefaultProcessingComponent()
        {
            return new BasicProcessingComponent();
        }

        public ICoreComponent GetDefaultRendererComponent()
        {
            return new BasicRendererComponent();
        }

        public ICoreComponent GetDefaultUpdateComponent()
        {
            return new BasicUpdateComponent();
        }
    }
}
