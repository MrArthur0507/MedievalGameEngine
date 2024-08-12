// See https://aka.ms/new-console-template for more information
using MedievalGameEngine.Engine;
using MedievalGameEngine.Engine.Core.Implementation;
using MedievalGameEngine.Factories.CoreComponentFactories.Implementation;



//The engine is a gameloop that goes through different stages during the cycle. Here those stages are CoreComponents
// The EngineBuilder class role is to set up the number of the core components and their order.
// The base game loop consists of InputProcessing stage, Update stage and render stage and the core component factory
// is giving base implementations of those. They can be replaced or new ones can be added in the execution flow be creating a class
// that inherits from CoreComponent and adding it to the engine builder.

EngineBuilder engBuilder = new EngineBuilder(new CoreComponentFactory());


engBuilder.AddComponent(engBuilder.Defaults.GetDefaultProcessingComponent());
engBuilder.AddComponent(engBuilder.Defaults.GetDefaultUpdateComponent());
engBuilder.AddComponent(engBuilder.Defaults.GetDefaultRendererComponent());
Engine eng = (Engine)engBuilder.Build();

eng.Start();
Console.ReadLine();