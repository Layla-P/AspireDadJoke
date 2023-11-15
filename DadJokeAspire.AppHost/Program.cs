using k8s.Models;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);


var dadjokeapi = builder.AddProject<Projects.DadJokeApi>("dadjokeapi");

builder.AddProject<Projects.EurekaDemo>("eurekademo")
    .WithReference(dadjokeapi);

var app = builder.Build();

app.Run();
