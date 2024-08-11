using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGameEngine.Engine
{
    public class Game
    {
        private bool isRunning;
        private int targetFrameRate = 60;
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

                ProcessInput();
                UpdateGameState();
                await BroadCastGameState();

                TimeSpan frameTime = DateTime.Now - start;
                double sleepTime = (1000 / targetFrameRate) - frameTime.TotalMilliseconds;

                if (sleepTime > 0)
                {
                    await Task.Delay((int)sleepTime);
                }
            }
        }

        private Task BroadCastGameState()
        {
            Console.WriteLine("Updated input");
            return Task.CompletedTask;
        }

        private void UpdateGameState()
        {
            Console.WriteLine("Update");
        }

        private void ProcessInput()
        {
            Console.WriteLine("Process");
        }

        public void Stop()
        {
            isRunning = false;
        }
    }
}
