using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<TabeTrack_Api>("api");

builder.Build().Run();
