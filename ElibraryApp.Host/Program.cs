var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ElibraryApp_Web>("ElibraryApp-Web");

builder.Build().Run();
