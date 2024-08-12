// See https://aka.ms/new-console-template for more information
using MedievalGameEngine.Engine;
using MedievalGameEngine.Engine.Core.Implementation;

Console.WriteLine("Hello, World!");

//Game game = new Game();
//game.Start();


EngineBuilder engBuilder = new EngineBuilder();

BasicProcessingComponent basicProcessingComponent = new BasicProcessingComponent();
BasicUpdateComponent basicUpdateComponent = new BasicUpdateComponent();
BasicRendererComponent basicRendererComponent = new BasicRendererComponent();

engBuilder.AddComponent(basicProcessingComponent);
engBuilder.AddComponent(basicUpdateComponent);
engBuilder.AddComponent(basicRendererComponent);
Engine eng = (Engine)engBuilder.Build();

eng.Start();
Console.ReadLine();