var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.ILoveNAV_ApiService>("apiservice");

builder.AddProject<Projects.ILoveNAV_Web>("webfrontend")
	.WithExternalHttpEndpoints()
	.WithReference(apiService);

builder.Build().Run();
