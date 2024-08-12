using MedievalGameEngine.Engine.Core.Contracts;
using MedievalGameEngine.Engine.Core.Implementation.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Implementation
{
    public class BasicUpdateComponent : CoreComponent
    {
        public override void Execute(IGameContext gameContext)
        {
            Console.WriteLine("Update");
            ExecuteNext(gameContext);
        }

    }
}
