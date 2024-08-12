using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine.Core.Contracts
{
    public interface IGameContext
    {
        LinkedList<string> inputs { get; set; }
    }
}
