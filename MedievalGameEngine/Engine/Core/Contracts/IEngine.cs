using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Contracts
{
    public interface IEngine
    {
        public ICoreComponent ExecutionFlow { get; }

    }
}
