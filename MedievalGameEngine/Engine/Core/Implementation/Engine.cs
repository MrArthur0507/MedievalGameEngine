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

        private bool isRunning;
        private int targetFrameRate = 1;
        public void Start()
        {
            isRunning = true;
            Task.Run(GameLoop);
        }

        private async Task GameLoop()
        {
            while (isRunning)
            {
                DateTime start = DateTime.Now;
                ICoreComponent currentComponent = ExecutionFlow;
                while (currentComponent != null)
                {
                    currentComponent.Execute();
                    currentComponent = currentComponent.Next;
                }

                TimeSpan frameTime = DateTime.Now - start;
                double sleepTime = (1000 / targetFrameRate) - frameTime.TotalMilliseconds;

                if (sleepTime > 0)
                {
                    await Task.Delay((int)sleepTime);
                }
            }
        }


        public void Stop()
        {
            isRunning = false;
        }



    }
}
