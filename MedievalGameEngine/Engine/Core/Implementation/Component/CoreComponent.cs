using MedievalGameEngine.Engine.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Implementation.Component
{
    public abstract class CoreComponent : ICoreComponent
    {
        public ICoreComponent Next { get; set; }
        
        public abstract void Execute(IGameContext gameContext);

        public void ExecuteNext(IGameContext gameContext)
        {
            Next.Execute(gameContext);
        }
    }
}
