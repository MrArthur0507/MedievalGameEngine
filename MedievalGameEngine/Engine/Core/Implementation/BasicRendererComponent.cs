using MedievalGameEngine.Engine.Core.Contracts;
using MedievalGameEngine.Engine.Core.Implementation.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Implementation
{
    public class BasicRendererComponent : CoreComponent
    {

        public override void Execute(IGameContext gameContext)
        {
            Console.WriteLine("Renderer");
            ExecuteNext(gameContext);
        }
    }
}
